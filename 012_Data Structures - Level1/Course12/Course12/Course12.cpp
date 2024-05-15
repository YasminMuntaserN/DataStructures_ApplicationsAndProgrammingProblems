
#include <iostream>
using namespace std;
#include <stack>
#include <queue>

/*
short FindNumberAlgorhim1(short arr1[10], short Number)

{
    int n = 10;
    short pos = -1;

    for (int i = 0; i <= n; i++)
    {
        if (arr1[i] == Number)
        {
            pos = i;
        }
    }

    return pos;

}

short FindNumberAlgorhim2(short arr1[10], short Number)

{
    int n = 10;

    for (int i = 0; i <= n; i++)
    {
        if (arr1[i] == Number)
        {
            return i;
        }
    }

    return -1;

}

int main()
{
    short arr1[10] = { 10,20,30,40,50,60,70,80,90,100 };

    cout << FindNumberAlgorhim1(arr1, 30) << "\n";
    cout << FindNumberAlgorhim2(arr1, 30) << "\n";

    system("pause>0");
    return 0;
}
*/

/*
int main() {
    stack <int>stNum;

    stNum.push(10);
    stNum.push(20);
    stNum.push(30);
    stNum.push(40);
    stNum.push(50);
    cout<<"count : " << stNum.size() << endl;
    cout << "Numbers are : \n";
    while (!stNum.empty()) {
        cout << stNum.top() << endl;
        stNum.pop();
    }
}*/

/*
int main() {
    stack <int>stNum1;
    stack <int>stNum2;

    stNum1.push(10);
    stNum1.push(20);
    stNum1.push(30);
    stNum1.push(40);
    stNum1.push(50);

    stNum2.push(60);
    stNum2.push(70);
    stNum2.push(80);
    stNum2.push(90);
    stNum2.push(100);

    stNum2.swap(stNum1);

    cout << " st Num1 :";
    while (!stNum1.empty()) {
        cout  << stNum1.top() <<"  ";
        stNum1.pop();
    }
    cout << "\n st Num2 :";
    while (!stNum2.empty()) {
        cout<<  stNum2.top() << "  ";
        stNum2.pop();
    }
}
*/

/*
int main() {
    queue <int >MyQueue;
    MyQueue.push(10);
    MyQueue.push(20);
    MyQueue.push(30);
    MyQueue.push(40);
    cout << "\n Count :" << MyQueue.size();
    cout << "\n Front :" << MyQueue.front();
    cout << "\n Back :" << MyQueue.back();
    cout << "\n MyQueue = ";
    while (!MyQueue.empty()) {
        cout << MyQueue.front() << " ";
        MyQueue.pop();
    }
}
*/

/*
int main() {
    queue <int >MyQueue;
    queue <int >MyQueue2;

    MyQueue.push(10);
    MyQueue.push(20);
    MyQueue.push(30);
    MyQueue.push(40);
    MyQueue.push(50);

    MyQueue2.push(60);
    MyQueue2.push(70);
    MyQueue2.push(80);
    MyQueue2.push(90);
    MyQueue2.push(100);

    MyQueue2.swap(MyQueue);

    cout << "\n MyQueue = ";
    while (!MyQueue.empty()) {
        cout << MyQueue.front() << " ";
        MyQueue.pop();
    }
    cout << "\n MyQueue2 = ";
    while (!MyQueue2.empty()) {
        cout << MyQueue2.front() << " ";
        MyQueue2.pop();
    }
}
*/

/*
class Node {
public :
    int value;
    Node* next;
};
int main() {
    Node* head;
    //Node* Node1 = NULL;
    //Node* Node2 = NULL;
    //Node* Node3 = NULL;

    //Node1 = new Node();
    //Node2 = new Node();
    //Node3 = new Node();

    Node* Node1 = new Node();
    Node* Node2 = new Node();
    Node* Node3 = new Node();
    Node1->value = 1;
    Node2->value = 2;
    Node3->value = 3;

    Node1->next = Node2;
    Node2->next = Node3;
    Node3->next = NULL;
     
    head = Node1;
    while (head != NULL)
    {
        cout << head->value << " ";
        head = head->next;
    }
}
*/

/* **********************InseartAtBegineng*************
class Node {
public :
    int value;
    Node* next;
};
void InseartAtBegineng(int value, Node*& head) {
    Node* new_Node = new Node();
    new_Node->value = value;
    new_Node->next = head;
    head = new_Node;
}
void print(Node* head) {
    while (head != NULL) {
        cout << head->value << "  ";
        head = head->next;
    }
}
int main() {
    Node* head = NULL;
    InseartAtBegineng(1, head);
    InseartAtBegineng(2, head);
    InseartAtBegineng(3, head);
    InseartAtBegineng(4, head);
    InseartAtBegineng(5, head);
    print(head);
}
*/

/* **********************Find*************
class Node {
public :
    int value;
    Node* next;
};
void InseartAtBegineng(int value, Node*& head) {
    Node* new_Node = new Node();
    new_Node->value = value;
    new_Node->next = head;
    head = new_Node;
}
Node* Find(Node* head, int value) {
    while (head != NULL) {
        if (head->value == value) return head;
        head = head->next;
    }
    return NULL;
}
void print(Node* head) {
    while (head != NULL) {
        cout << head->value << "  ";
        head = head->next;
    }
}
int main() {
    Node* head = NULL;
    InseartAtBegineng(1, head);
    InseartAtBegineng(2, head);
    InseartAtBegineng(3, head);
    InseartAtBegineng(4, head);
    InseartAtBegineng(5, head);
    print(head);
    Node* n1 = Find(head, 10);
    if (n1 != NULL) cout << "\n Node Found . \n";
    else cout << "\n Node Not Found . \n";
}
*/

/********************Insert After ***********
class Node {
public :
    int Value;
    Node* next;
};
void InsertAtBeginnaing(Node * &head , int value) {
    Node* New_Node = new Node();
    New_Node->Value = value;
    New_Node->next = head;
    head = New_Node;
}
Node* find(Node* head, int value) {
    while (head != NULL) {
        if (head->Value == value) return head;
        head = head->next;
    }
    return NULL;
}
void InsertAfter(Node* Prev_Node ,int value) {
    if (Prev_Node == NULL) {
        cout << "The given previous nod cannot be null \n";
        return;
    }
    Node* New_Node = new Node();
    New_Node->Value = value;
    New_Node->next = Prev_Node->next;
    Prev_Node->next = New_Node;
}
void print(Node* head) {
    while (head != NULL) {
        cout << head->Value << "  ";
        head = head->next;
    }
    cout << endl;
}
int main() {
    Node* head = NULL;
    InsertAtBeginnaing(head, 1);
    InsertAtBeginnaing(head, 2);
    InsertAtBeginnaing(head, 3);
    InsertAtBeginnaing(head, 4);
    InsertAtBeginnaing(head, 5);
    print(head);
    Node *N1 = find(head, 2);
   // (N1 != NULL) ? cout << " Find :)" : cout << "Not Found :(";
    InsertAfter(N1, 500);
    print(head);
}
*/

/********************Insert In the End**********
class Node {
public:
    int Value;
    Node* next;
};

void InsertEnd( int value , Node* &head) {
    Node* new_Node = new Node();

    new_Node->Value = value;
    new_Node->next = NULL;

    if (head == NULL) {
        head= new_Node;
        return;
    }

    Node* last_Node = head;
    while (last_Node->next != NULL) {
        last_Node= last_Node->next ;
    }
    last_Node->next = new_Node;
    return;
}


void print(Node* head) {
    while (head != NULL) {
        cout << head->Value << "  ";
        head = head->next;
    }
    cout << endl;
}
int main() {
    Node* head = NULL;
    InsertEnd(1, head);
    InsertEnd(2, head);
    InsertEnd(3, head);
    InsertEnd(4, head);
    InsertEnd(5, head);

    print(head);
}*/

/******************** Deleat **********
class Node {
public:
    int Value;
    Node* next;
};

void InsertEnd( int value , Node* &head) {
    Node* new_Node = new Node();

    new_Node->Value = value;
    new_Node->next = NULL;

    if (head == NULL) {
        head= new_Node;
        return;
    }

    Node* last_Node = head;
    while (last_Node->next != NULL) {
        last_Node= last_Node->next ;
    }
    last_Node->next = new_Node;
    return;
}
void DeleatNode(int value, Node*& head) {
    Node* Current = head, * prev = head;

    if (head == NULL) return;

    if (Current->Value == value) {
        head = Current->next;
        delete Current;
        return;
    }
    while (Current != NULL && Current->Value != value) {
        prev = Current;
        Current = Current->next;
    }
    if (Current == NULL) return;
    prev->next = Current->next;
    delete Current;
}

void print(Node* head) {
    while (head != NULL) {
        cout << head->Value << "  ";
        head = head->next;
    }
    cout << endl;
}
int main() {
    Node* head = NULL;
    InsertEnd(1, head);
    InsertEnd(2, head);
    InsertEnd(3, head);
    InsertEnd(4, head);
    InsertEnd(5, head);
    print(head);
    DeleatNode(3, head);
    print(head);
}
*/

/******************** Delrtr In the First**********
class Node {
public:
    int Value;
    Node* next;
};

void InsertEnd( int value , Node* &head) {
    Node* new_Node = new Node();

    new_Node->Value = value;
    new_Node->next = NULL;

    if (head == NULL) {
        head= new_Node;
        return;
    }

    Node* last_Node = head;
    while (last_Node->next != NULL) {
        last_Node= last_Node->next ;
    }
    last_Node->next = new_Node;
    return;
}
void DeleteFirst(Node* &head) {
    Node* current = head;
    if (current == NULL)return;
    head = current->next;
    delete current;
}

void print(Node* head) {
    while (head != NULL) {
        cout << head->Value << "  ";
        head = head->next;
    }
    cout << endl;
}
int main() {
    Node* head = NULL;
    InsertEnd(1, head);
    InsertEnd(2, head);
    InsertEnd(3, head);
    InsertEnd(4, head);
    InsertEnd(5, head);
    print(head);

    DeleteFirst(head);
    print(head);

    DeleteFirst(head);
    print(head);

}
*/

/******************** Delete In the End**********
class Node {
public:
    int Value;
    Node* next;
};

void InsertEnd( int value , Node* &head) {
    Node* new_Node = new Node();

    new_Node->Value = value;
    new_Node->next = NULL;

    if (head == NULL) {
        head= new_Node;
        return;
    }

    Node* last_Node = head;
    while (last_Node->next != NULL) {
        last_Node= last_Node->next ;
    }
    last_Node->next = new_Node;
    return;
}
void DeleteEnd(Node* &head) {
    Node* current = head ,*prev=head;
    if (current == NULL)return;
    if (current->next == NULL) {
        head = NULL;
        delete current;
    }
    while (current != NULL && current->next != NULL) {
        prev = current;
        current = current->next;
    }
    prev ->next=NULL;
    delete current; // ﬂ·„… œÌ·Ì  „« » Õ–› «·»ÊÌ‰ — » Õ–›  «·„ﬂ«‰ «·Ì »Ì√‘— ⁄·ÌÂ Â«œ «·»ÊÌ‰ —
}

void print(Node* head) {
    while (head != NULL) {
        cout << head->Value << "  ";
        head = head->next;
    }
    cout << endl;
}
int main() {
    Node* head = NULL;
    InsertEnd(1, head);
    InsertEnd(2, head);
    InsertEnd(3, head);
    InsertEnd(4, head);
    InsertEnd(5, head);
    print(head);

    DeleteEnd(head);
    print(head);

    DeleteEnd(head);
    print(head);
}
*/

/*££££££££££££££££££ ⁄«œ· ‰”Ì„££££££££££££££££££

class LinkedList {
    struct Node {
        int item;
        Node* next;
    };
    Node* first;
    Node* last;
    int length;
public:
    LinkedList() {
        first = last = NULL;
        length = 0;
    }
    bool isEmpty() {
        return length == 0;
    }
    //Add to LinkedList
    void IseratFirst(int element) {
        Node* new_Node = new Node();
        new_Node->item = element;
        if (length == 0) { 
            first = last = new_Node;
            new_Node->next = NULL;
        }
        else {
            new_Node->next = first;
            first = new_Node;
        }
        length++;
    }
    void IseratLast(int element) {
        Node* new_Node = new Node();
        new_Node->item = element;
        if (length == 0) {
            first = last = new_Node;
            new_Node->next = NULL;
        }
        else {
            last->next = new_Node;
            new_Node->next=NULL;
            last = new_Node;
        }
        length++;
    }
    void IseratAtPosition(int pos, int element) {
        if (pos <0 || pos>length) {
            cout << "out Of Range";
        }
        else {
            Node* newNode = new Node();
            newNode->item = element;
            if (pos == 0) {
                IseratFirst(element);
            }
            else if (pos == length) {
                IseratLast(element);
            }
            else {
                Node* cur = first;
                for (int i = 1;i < pos;i++) {
                    cur = cur->next;
                }
                newNode->next = cur->next;
                cur->next = newNode;
                length++;
            }
        }
    }
    //Remove from LinkedList
    void RemoveFirst() {
        if (length == 0) {
            cout << "Empty List cant Remove " << endl;
            return;
        }
        else if (length == 1) {
            delete first;
            last = first = NULL;
            length--;
        }else{
            Node* curr = first;
            first = first->next;
            delete curr;
            length--;
        }
    }
    void RemoveLast() {
        if (length == 0) {
            cout << "Empty List cant Remove " << endl;
            return;
        }
        else if (length == 1) {
            delete first;
            last = first = NULL;
            length--;
        }
        else {
            Node* curr = first , *prev= first;
            while (curr != NULL && curr->next != NULL) {
                prev = curr;
                curr = curr->next;
            }
            prev->next =NULL;
            delete curr;
            length--;
        }
    }
    //position „‰ Œ·«·  
    void RemoveAtPosition(int pos) {
        if (length == 0) {
            cout << "Empty List cant Remove " << endl;
            return;
        }
        else if (length == 1) {
            delete first;
            last = first = NULL;
            length--;

        }else if (pos == 0) {
            RemoveFirst();
        }
        else if (pos == length) {
            RemoveLast();
        }
        else {
         Node* curr = first, * prev = first;
         for (int i = 0;i < pos;i++) {
             prev = curr;
             curr = curr->next;
         }
         prev->next = curr->next;
         delete curr;
         length--;
            }
        }
    // element „‰ Œ·«· 
    void RemoveFromElement(int element) {
        Node* curr = first, * prev = first;
        if (length == 0) {
            cout << "Empty List cant Remove " << endl;
            return;
        }
        else if (length == 1) {
            delete first;
            last = first = NULL;
            length--;
        }
        else if (curr->item == element) {
            RemoveFirst();
        }
        else {
            while (curr != NULL ) {
                if (curr->item == element ) {
                    prev->next = curr->next;
                    delete curr;
                    return;
                }
                else if (curr->item == element && curr->next != NULL) {
                    prev->next = NULL;
                    delete curr;
                    return;
                }
                else {
                    prev = curr;
                    curr = curr->next;
                }
            }
            length--;
        }
    }
    // Reverse LinkedList
    void ReverseLinkedList() {
        Node* curr = first, * prev = NULL ,*next= curr->next;
        while (curr != NULL && curr->next != NULL) {
            curr->next = prev;
            prev = curr;
            curr = next;
            next = curr->next;
        }
        curr->next = prev;
        first = curr;
    }
    // to search
    bool search(int element) {
        Node* cur = first;
        while (cur != NULL) {
            if (cur->item == element) {
                return true;
            }
            cur = cur->next;
        }
        return false;
    }
    // to search and return index
    int searchPos(int element) {
        int pos = 0;
        Node* cur = first;
        while (cur != NULL) {
            if (cur->item == element) {
                return pos;
            }
            cur = cur->next;
            pos++;
        }
        return -1;
    }
    void print() {
        Node* cur = first;
        while (cur != NULL) {
            cout << cur->item << "  ";
            cur = cur->next;
        }
        cout << endl;
    }
};
int main() {
    LinkedList l;
    l.IseratFirst(1);
    l.IseratFirst(2);
    l.IseratFirst(3);
    l.IseratFirst(4);
    l.IseratFirst(5);
    l.print();
    l.ReverseLinkedList();
    l.print();
    l.search(5) ? cout << " Found :) " : cout << " Not Found :(";
    cout << endl << l.searchPos(1);
}
*/

/*
*********Dobluy linked list implemintation************
class Node {
public:
    int value;
    Node* next;
    Node* Prev;
};
void print(Node* head) {
    while (head != NULL) {
        cout << head->value << "  ";
        head = head->next;
    }
    cout << endl;
}
void IseartAtBegineng(Node* &head , int value) {
    Node* new_Node = new Node();
    new_Node->value = value;
    new_Node->next = head;
    new_Node->Prev = NULL;
    if (head != NULL) {
        head->Prev = new_Node;
    }
    head = new_Node;
}
Node *findFromList(Node* head, int value) {
    Node* curr = head;
    while (curr != NULL) {
        if (curr->value == value)return curr;
        curr = curr->next;
    }
    return NULL;
}
void InsertAfter(Node* prevNode, int value) {
    Node* new_Node = new Node();
    new_Node->value = value;
    new_Node->next = prevNode->next;
    new_Node->Prev = prevNode;
    
    if (prevNode->next != NULL) {
        prevNode->next->Prev = new_Node;
    }
    prevNode->next = new_Node;
}
void InseartInTheEnd(Node* head, int value) {
    Node* new_Node = new Node();
    new_Node->value = value;
    new_Node->next = NULL;
    if (head == NULL) {
        new_Node->Prev = NULL;
        head = new_Node;
    }
    else {
        while (head->next != NULL) {
            head = head->next;
        }
        new_Node->Prev = head;
        head->next = new_Node;
    }
}
void DeleteFirstNode(Node*& head) {
    Node* NodeToDelete = head;
    if (head == NULL) {
        return;
    }
    NodeToDelete->next->Prev = NULL;
    head = NodeToDelete->next;
    delete NodeToDelete;
}

void DeleteLastNode(Node*& head) {
    Node* NodeToDelete = head;
    if (head == NULL) {
        return;
    }
    if (NodeToDelete->Prev == NULL) {
        DeleteFirstNode(head);
        return;
    }

    while (NodeToDelete->next->next != NULL) //Ì⁄‰Ì «Õ‰« Ê«ﬁ›Ì‰ ⁄‰œ «·‰Êœ «·Ì ﬁ»· «·«ŒÌ—…
    {
        NodeToDelete = NodeToDelete->next;
    }
    Node* temp = NodeToDelete->next;
    temp->next = NULL; // === NodeToDelete->next->next=null; delete NodeToDelete;
    delete temp;
}


int main() {
    Node* head =NULL   ;

    IseartAtBegineng(head ,1);
    IseartAtBegineng(head, 2);
    IseartAtBegineng(head, 3);
    IseartAtBegineng(head, 4);
    IseartAtBegineng(head, 5);
    Node* n1 = findFromList(head, 2);
  DeleteNode(head , n1);
    print(head);
    DeleteFirstNode(head);
    print(head);
    DeleteLastNode(head);
    print(head);
}
 */