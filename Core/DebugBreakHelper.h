#pragma once
#include "stdafx.h"
#include "Debugger.h"

class DebugBreakHelper
{
private:
	Debugger* _debugger;
	bool _needResume = false;

public:
	DebugBreakHelper(Debugger* debugger)
	{
		_debugger = debugger;

		if(!debugger->IsExecutionStopped()) {
			debugger->SetSendNotificationFlag(false);
			debugger->Step(1);
			while(!debugger->IsExecutionStopped()) {}
			_needResume = true;
		}
	}

	~DebugBreakHelper()
	{
		if(_needResume) {
			_debugger->Run();
			_debugger->SetSendNotificationFlag(true);
		}
	}
};