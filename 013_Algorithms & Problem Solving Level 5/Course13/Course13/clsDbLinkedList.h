#pragma once
#include <iostream>
using namespace std;

template <class T>
class clsDbLinkedList
{
protected:
	int _Size = 0;

public:

	class Node
	{

	public:
		T value;
		Node* next;
		Node* prev;
	};
	Node* head = NULL;

	void PrintList() {
		Node* Current = head;

		while (Current != NULL) {
			cout << Current->value << " ";
			Current = Current->next;
		}
		cout << "\n";
		delete Current;
	}

	void InsertAtBeginning(T value) {
		Node* newNode = new Node();
		_Size++;
		newNode->value = value;
		newNode->next = head;
		newNode->prev = NULL;

		if (head != NULL) {
			head->prev = newNode;
		}
		head = newNode;
	}

	void InsertAfter(Node* prevNode, T value) {
		Node* newNode = new Node();
		_Size++;
		newNode->value = value;
		newNode->next = prevNode->next;
		newNode->prev = prevNode;

		if (prevNode->next != NULL) {
			prevNode->next->prev = newNode;
		}
		prevNode->next = newNode;

	}

	Node* Find(T value) {
		Node* temp = head;
		while (temp != NULL) {
			if (temp->value == value) {
				return temp;
			}
			temp = temp->next;
		}
		return NULL;
	}

	void InsertAtEnd(T value) {
		Node* newNode = new Node();
		newNode->value = value;
		newNode->next = NULL;
		if (head == NULL) {
			newNode->prev = NULL;
			head = newNode;
		}
		else {
			Node* current = head;
			while (current->next != NULL) {
				current = current->next;
			}
			current->next = newNode;
			newNode->prev = current;
		}
		_Size++;
	}

	void DeleteNode(Node*& NodeToDelete) {
		if (head == NULL || NodeToDelete == NULL) {
			return;
		}
		if (NodeToDelete == head) {
			head = NodeToDelete->next;
		}
		if (NodeToDelete->next != NULL) {
			NodeToDelete->prev->next = NodeToDelete->next;
		}
		if (NodeToDelete->prev != NULL) {
			NodeToDelete->next->prev = NodeToDelete->prev;
		}
		delete NodeToDelete;
		_Size--;
	}

	void DeleteFirstNode() {
		if (head == NULL) {
			return;
		}
		Node* temp = head;
		head = temp->next;
		if (head != NULL) {
			head->prev = NULL;
		}
		delete temp;
		_Size--;

	}

	void DeleteLastNode() {
		Node* temp = head;
		if (head == NULL) {
			return;
		}
		if (head->next == NULL) {
			delete head;
			head = NULL;
			return;
		}
		while (temp->next->next != NULL) {
			temp = temp->next;
		}
		Node* lastNode = temp;
		lastNode->prev->next = NULL;
		delete lastNode;
		_Size--;

	}

	bool isEmpty() {
		return _Size == 0;
	}

	int size() {
		return _Size;
	}

	void Clear() {
		while (_Size > 0) {
			DeleteFirstNode();
		}
	}

	void Reverse() {
		Node* current = head;
		Node* temp = nullptr;
		while (current != nullptr) {
			temp = current->prev;
			current->prev = current->next;
			current->next = temp;
			current = current->prev;
		}
		if (temp != nullptr) {
			head = temp->prev;
		}
	}

	/*
	Node* GetNode(int index) {
		if (index > _Size - 1 || index < 0) return NULL;

		Node* temp = head;
		for (int i = 0;i < index;i++) {
			temp = temp->next;
		}
		return temp;
	}
	*/

	Node* GetNode(int Index)
	{
		int Counter = 0;

		if (Index > _Size - 1 || Index < 0)
			return NULL;

		Node* Current = head;
		while (Current != NULL && (Current->next != NULL)) {

			if (Counter == Index)
				break;

			Current = Current->next;
			Counter++;

		}

		return Current;
	}

	T GetItem(int index) {
		Node* ItemNode = GetNode(index);
		return (ItemNode == NULL) ? NULL : ItemNode->value;
	}

	void UpdateItem(int index, T value) {
		Node* ItemNode = GetNode(index);
		ItemNode->value = value;
	}

	bool InsertAfter(int index, T value) {
		if (index > _Size - 1 || index < 0) return false;
		Node* ItemNode = GetNode(index);
		if (ItemNode != NULL) {
			InsertAfter(ItemNode, value);
			return true;
		}
		else {
			return false;
		}
	}
};

