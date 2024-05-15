#pragma once
#include <string>
#include <iostream>
#include "clsMyStack.h"
using namespace std;

class clsMyString
{
private :
	string _Value = "";
	clsMyStack <string> _Undo;
	clsMyStack <string> _Redo;

public:

	void setValue(string value) {
		_Undo.push(_Value);
		_Value = value;
	}

	string getValue() {
		return _Value;
	}
	__declspec(property(get = getValue, put = setValue)) string Value;

	bool Undo() {
		if (_Undo.IsEmpty()) {
			return false;
		}
		else {
			_Redo.push(_Value);
			_Value = _Undo.Top();
			_Undo.pop();
			return true;
		}
	}

	bool Redo() {
		if (_Redo.IsEmpty()) {
			return false;
		}
		else {
			_Undo.push(_Value);
			_Value = _Redo.Top();
			_Redo.pop();
			return true;
		}
	}


};

