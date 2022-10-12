public class ListasEnlazadas {
    private node head;
    private node tail;
    private string name;

    public createList (string listname){
        name = listName;
        head = tail = null;
    }

    public bool isListEmpty(){
        if(head==null){
            return true;
        }
        return false;
    }

    public void inssertHeadNode(int data){
        node newHead = new node()
        if(isListEmpty){
           newHead.newNode (data);
           head = tail = newHead;
        }
        else{
            newHead.setData(data);
            newHead.setNext(head);
            head = newHead;
        }
    }

    public void InsertTailNode(int data){
        node newTail = new node()
        if(isListEmpty){
            head = tail = newTail;
        }
        else{
            tail.setNext(newTail)
            tail = newTail;
        }

    }

    public int deleteHead(){
        if(isListEmpty){
            throw new emptyListException(name);
        }
        int deleteNode = head.getData;
        if (head == tail){
            head = tail = null;
        }
        else{
            head=head.getNext;
        }
        return deleteNode;

    }

}