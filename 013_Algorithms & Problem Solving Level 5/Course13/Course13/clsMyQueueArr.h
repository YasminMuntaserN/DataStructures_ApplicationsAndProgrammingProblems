#pragma once
#include "clsDynamicArray.h"

template <class T>
class clsMyQueueArr
{

protected:
	clsDynamicArray <T> _MyList;

public:

	void push(T Item)
	{
		_MyList.InsertAtEnd(Item);
	}

	void pop()
	{
		_MyList.DeleteFirstItem();
	}

	void Print()
	{
		_MyList.PrintList();
	}

	int Size()
	{
		return _MyList.Size();
	}

	bool IsEmpty()
	{
		return _MyList.IsEmpty();
	}

	T front()
	{
		return _MyList.GetItem(0);
	}

	T back()
	{
		return _MyList.GetItem(Size() - 1);
	}

	T GetItem(int index) {
		return _MyList.GetItem(index);
	}

	void Reverse() {
		_MyList.Reverse();
	}

	void UpdateItem(int index, T value) {
	//	_MyList.UpdateItem(index, value);
		_MyList.SetItem(index, value);
	}

	void InsertAtFront(T value) {
		_MyList.InsertAtBeginning(value);
	}

	void InsertAtBack(T value) {
		_MyList.InsertAtEnd(value);
	}

	void clear() {
		_MyList.Clear();
	}
	void InsertAfter(int index, T value) {
		_MyList.InsertAfter(index, value);
	}
};

