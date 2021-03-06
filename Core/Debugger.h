#pragma once

#include "stdafx.h"
#include <atomic>
#include <deque>
#include <unordered_set>
using std::atomic;
using std::deque;
using std::unordered_set;

#include "Breakpoint.h"
#include "TraceLogger.h"
#include "../Utilities/SimpleLock.h"
#include "CodeDataLogger.h"
#include "DebuggerTypes.h"

class CPU;
class APU;
class PPU;
class MemoryManager;
class Console;
class Assembler;
class Disassembler;
class LabelManager;
class MemoryDumper;
class MemoryAccessCounter;
class Profiler;
class CodeRunner;
class BaseMapper;
class ScriptHost;
class DebugHud;

class Debugger
{
private:
	static Debugger* Instance;

	const static int BreakpointTypeCount = 6;

	shared_ptr<Disassembler> _disassembler;
	shared_ptr<Assembler> _assembler;
	shared_ptr<MemoryDumper> _memoryDumper;
	shared_ptr<CodeDataLogger> _codeDataLogger;
	shared_ptr<MemoryAccessCounter> _memoryAccessCounter;
	shared_ptr<LabelManager> _labelManager;
	shared_ptr<TraceLogger> _traceLogger;
	shared_ptr<Profiler> _profiler;
	unique_ptr<CodeRunner> _codeRunner;
	unique_ptr<DebugHud> _debugHud;

	shared_ptr<Console> _console;
	shared_ptr<CPU> _cpu;
	shared_ptr<PPU> _ppu;
	shared_ptr<APU> _apu;
	shared_ptr<MemoryManager> _memoryManager;
	shared_ptr<BaseMapper> _mapper;

	bool _hasScript;
	int _nextScriptId;
	vector<shared_ptr<ScriptHost>> _scripts;
	
	bool _bpUpdateNeeded;
	SimpleLock _bpUpdateLock;

	atomic<bool> _stopFlag;
	atomic<bool> _executionStopped;
	atomic<int32_t> _suspendCount;
	vector<Breakpoint> _newBreakpoints;
	vector<Breakpoint> _breakpoints[BreakpointTypeCount];
	vector<vector<int>> _breakpointRpnList[BreakpointTypeCount];
	bool _hasBreakpoint[BreakpointTypeCount] = {};

	vector<uint8_t> _frozenAddresses;

	bool _hideTopOfCallstack;
	deque<uint32_t> _callstackAbsolute;
	deque<uint32_t> _callstackRelative;

	unordered_set<uint32_t> _functionEntryPoints;

	ExpressionEvaluator _watchExpEval = ExpressionEvaluator(this);
	ExpressionEvaluator _bpExpEval = ExpressionEvaluator(this);
	DebugState _debugState;

	SimpleLock _breakLock;

	//Used to alter the executing address via "Set Next Statement"
	uint16_t *_currentReadAddr;
	uint8_t *_currentReadValue;
	int32_t _nextReadAddr;
	uint16_t _returnToAddress;

	uint32_t _flags;

	string _romName;
	string _disassemblerOutput;
	atomic<int32_t> _stepCount;
	atomic<int32_t> _ppuStepCount;
	atomic<int32_t> _stepCycleCount;
	atomic<uint8_t> _lastInstruction;
	atomic<bool> _stepOut;
	atomic<int32_t> _stepOverAddr;
	atomic<bool> _sendNotification;

	int32_t _ppuViewerScanline;
	int32_t _ppuViewerCycle;

	uint16_t _ppuScrollX;
	uint16_t _ppuScrollY;

	int32_t _prevInstructionCycle;
	int32_t _curInstructionCycle;
	int32_t _runToCycle;
	bool _needRewind;
	vector<stringstream> _rewindCache;

	uint32_t _inputOverride[4];

private:
	void UpdateBreakpoints();

	void PrivateProcessPpuCycle();
	bool PrivateProcessRamOperation(MemoryOperationType type, uint16_t &addr, uint8_t &value);
	void PrivateProcessVramReadOperation(MemoryOperationType type, uint16_t addr, uint8_t &value);
	void PrivateProcessVramWriteOperation(uint16_t addr, uint8_t &value);
	bool HasMatchingBreakpoint(BreakpointType type, OperationInfo &operationInfo);
	
	void UpdateCallstack(uint32_t addr);
	void PrivateProcessInterrupt(uint16_t cpuAddr, uint16_t destCpuAddr, bool forNmi);

	void ProcessStepConditions(uint32_t addr);
	bool SleepUntilResume();

	void RemoveExcessCallstackEntries();

public:
	Debugger(shared_ptr<Console> console, shared_ptr<CPU> cpu, shared_ptr<PPU> ppu, shared_ptr<APU> apu, shared_ptr<MemoryManager> memoryManager, shared_ptr<BaseMapper> mapper);
	~Debugger();

	void SetFlags(uint32_t flags);
	bool CheckFlag(DebuggerFlags flag);
	
	void SetBreakpoints(Breakpoint breakpoints[], uint32_t length);
	
	shared_ptr<LabelManager> GetLabelManager();

	void GetFunctionEntryPoints(int32_t* entryPoints, int32_t maxCount);
	int32_t GetFunctionEntryPointCount();

	void GetCallstack(int32_t* callstackAbsolute, int32_t* callstackRelative);
	
	void GetState(DebugState *state, bool includeMapperInfo = true);
	void SetState(DebugState state);

	void Suspend();
	void Resume();

	void PpuStep(uint32_t count = 1);
	void Step(uint32_t count = 1, bool sendNotification = true);
	void StepCycles(uint32_t cycleCount = 1);
	void StepOver();
	void StepOut();
	void StepBack();
	void Run();
	void SetSendNotificationFlag(bool enabled);

	bool LoadCdlFile(string cdlFilepath);
	void ResetCdl();
	void UpdateCdlCache();
	bool IsMarkedAsCode(uint16_t relativeAddress);
	shared_ptr<CodeDataLogger> GetCodeDataLogger();

	void SetNextStatement(uint16_t addr);
	void SetPpuViewerScanlineCycle(int32_t scanline, int32_t cycle);

	bool IsExecutionStopped();

	void GenerateCodeOutput();
	const char* GetCode(uint32_t &length);
	
	int32_t GetRelativeAddress(uint32_t addr, AddressType type);
	int32_t GetAbsoluteAddress(uint32_t addr);	
	int32_t GetAbsoluteChrAddress(uint32_t addr);
	void GetAbsoluteAddressAndType(uint32_t relativeAddr, AddressTypeInfo* info);

	shared_ptr<Profiler> GetProfiler();
	shared_ptr<Assembler> GetAssembler();
	shared_ptr<TraceLogger> GetTraceLogger();
	shared_ptr<MemoryDumper> GetMemoryDumper();
	shared_ptr<MemoryAccessCounter> GetMemoryAccessCounter();

	int32_t EvaluateExpression(string expression, EvalResultType &resultType);
	
	static bool ProcessRamOperation(MemoryOperationType type, uint16_t &addr, uint8_t &value);
	static void ProcessVramReadOperation(MemoryOperationType type, uint16_t addr, uint8_t &value);
	static void ProcessVramWriteOperation(uint16_t addr, uint8_t &value);
	static void ProcessPpuCycle();
	
	static void SetLastFramePpuScroll(uint16_t x, uint16_t y);
	uint32_t GetPpuScroll();

	static void ProcessInterrupt(uint16_t cpuAddr, uint16_t destCpuAddr, bool forNmi);

	static bool IsEnabled();
	static void BreakIfDebugging();

	void SetFreezeState(uint16_t address, bool frozen);
	void GetFreezeState(uint16_t startAddress, uint16_t length, bool* freezeState);

	void StartCodeRunner(uint8_t *byteCode, uint32_t codeLength);
	void StopCodeRunner();

	void GetNesHeader(uint8_t* header);
	void SaveRomToDisk(string filename, bool saveAsIps, uint8_t* header);
	void RevertPrgChrChanges();
	bool HasPrgChrChanges();

	int32_t FindSubEntryPoint(uint16_t relativeAddress);
	
	static bool HasInputOverride(uint8_t port);
	static uint32_t GetInputOverride(uint8_t port);
	void SetInputOverride(uint8_t port, uint32_t state);

	int32_t LoadScript(string content, int32_t scriptId);
	void RemoveScript(int32_t scriptId);
	const char* GetScriptLog(int32_t scriptId);
	void ProcessCpuOperation(uint16_t addr, uint8_t &value, MemoryOperationType type);
	void ProcessPpuOperation(uint16_t addr, uint8_t &value, MemoryOperationType type);
	void ProcessEvent(EventType type);
};