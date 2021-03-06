#pragma once

#include "stdafx.h"
#include "MMC3.h"

class MMC3_115 : public MMC3
{
private:
	uint8_t _prgReg = 0;
	uint8_t _chrReg = 0;

protected:
	virtual uint16_t RegisterStartAddress() override { return 0x6000; }

	virtual void SelectCHRPage(uint16_t slot, uint16_t page, ChrMemoryType memoryType = ChrMemoryType::Default) override
	{
		page |= (_chrReg << 8);
		BaseMapper::SelectCHRPage(slot, page);
	}

	virtual void UpdateState() override
	{
		MMC3::UpdateState();

		if(_prgReg & 0x80) {
			SelectPRGPage(0, (_prgReg & 0x0F) << 1);
			SelectPRGPage(1, ((_prgReg & 0x0F) << 1) + 1);
		}
	}

	virtual void WriteRegister(uint16_t addr, uint8_t value) override
	{
		if(addr < 0x8000) {
			if(addr & 0x01) {
				_chrReg = value & 0x01;
			} else {
				_prgReg = value;
			}
			UpdateState();
		} else {
			MMC3::WriteRegister(addr, value);
		}
	}

	virtual void StreamState(bool saving) override
	{
		MMC3::StreamState(saving);
		Stream(_prgReg, _chrReg);
	}
};