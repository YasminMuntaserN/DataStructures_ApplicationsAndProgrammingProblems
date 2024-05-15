#include <iostream>
using namespace std;

template <class T>
class clsDynamicArray
{
protected:
	int _Size = 0;
	T* _TempArray;

public :
	T* OriginalArray;

	clsDynamicArray(int SizeOfArray) { // constructir 
		if (_Size < 0) _Size = 0;

		_Size = SizeOfArray;
		OriginalArray = new T[_Size];
	}

	~clsDynamicArray() { // destractor
		delete[] OriginalArray;
	}

	bool SetItem(int index, T value) {
		if (index >= _Size || _Size < 0) {
			return false;
		}

		OriginalArray[index] = value;
		return true;
	}

	bool IsEmpty() {
		return(_Size == 0 );
	}

	int Size() {
		return _Size;
	}

	void PrintList() {
		for (int i = 0;i < _Size;i++) {
			cout << OriginalArray[i] << "  ";
		}
		cout << "\n";
	}

	void Resize(int NewSize)
	{
		if (NewSize < 0)
		{
			NewSize = 0;
		};
		_TempArray = new T[NewSize];

		//limit the original size to the new size if it is less.
		if (NewSize < _Size)
			_Size = NewSize;

		//copy all data from original array until the size
		for (int i = 0; i < _Size; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		_Size = NewSize;

		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}

	T GetItem(int index) {
		return OriginalArray[index];
	}

	void Reverse() {
		//_TempArray = new T[_Size];
		int count = 0;
		for (int i= _Size-1; i >=0;i--) {
			//_TempArray[count] = OriginalArray[i];
			OriginalArray[count] = OriginalArray[i];
			count++;
		}
		//delete[]OriginalArray;
		//OriginalArray = _TempArray;
	}

	void Clear() {
		_Size = 0;
		_TempArray = new T[_Size];
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}

	bool DeleteItemAt(int index) {
		if (index >= _Size || index < 0) {
			return false;
		}
		_Size--;
		_TempArray = new T[_Size];
		for (int i = 0; i < index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		for (int i = index + 1; i < _Size + 1; i++) {
			_TempArray[i-1] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;

	}

	bool DeleteFirstItem() {
	return	DeleteItemAt(0);
	}

	bool DeleteLastItem() {
		return	DeleteItemAt(_Size-1);
	}

	int Find(T value) {
		for (int i = 0; i < _Size;i++) {
			if (OriginalArray[i] == value) {
				return i;
			}
		}
		return -1;
	}

	bool DeleteItem(T value) {
		int Index = Find(value);
		if (Index == -1) return false;
		return DeleteItemAt(Index);
	}

	bool InsertAt(int index, T value) {

		if (index > _Size || index < 0)
		{
			return false;
		}
		_Size++;
		_TempArray = new T[_Size];
		for (int i = 0;i < index; i++) {
			_TempArray[i] = OriginalArray[i];
		}
		_TempArray[index] = value;

		for (int i = index ; i < _Size - 1; i++) {
			_TempArray[i+1] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}

	void InsertAtBeginning(T value) {
		InsertAt(0, value);
	}

	bool InsertBefore(int index, T value) {
		if(index < 1)
			return InsertAt(0, value);
		else
		return InsertAt(index - 1, value);
	}

	bool InsertAfter(int index, T value) {
		if (index >= _Size)
			return (_Size - 1, value);
		else
		   return InsertAt(index + 1, value);
	}

	bool InsertAtEnd (T value) {
		return InsertAt(_Size, value);
	}

	bool UpdateItem(int index, T value) {
		if (index > _Size || index < 0)
		{
			return false;
		}
		_TempArray = new T[_Size];
		for (int i = 0;i < index; i++) {
			_TempArray[i] = OriginalArray[i];
		}
		_TempArray[index] = value;

		for (int i = index+1; i < _Size; i++) {
			_TempArray[i] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;
	}
};
