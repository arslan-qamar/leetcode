package LeetCode.CircularArrayBuffer;

public class CircularBuffer {


    private int head;

    public int getTail() {
        return tail;
    }

    public int getHead() {
        return head;
    }

    private int tail;
    private int[] items;
    private final int capacity;

    CircularBuffer(int capacity) {
        this.items = new int[capacity];
        this.capacity = capacity;
        this.head = 0;
        this.tail = -1;
    }

    public int insert(int value) {

        tail++;
        int index = tail % capacity;
        items[index] = value;

        if(tail > head && index == (head % capacity))
        {
            head++;
        }

        return index;
    }

    public int delete() {

        int returnVal = items[head % capacity];

        if(head != tail) {
            head++;
        }

        return returnVal;
    }

}
