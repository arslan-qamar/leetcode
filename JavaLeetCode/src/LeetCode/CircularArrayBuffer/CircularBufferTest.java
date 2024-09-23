package LeetCode.CircularArrayBuffer;

import org.junit.jupiter.api.Test;

import static org.assertj.core.api.AssertionsForClassTypes.assertThat;

class CircularBufferTest {

    @Test
    void insert() {
        CircularBuffer circularBuffer = new CircularBuffer(4);

        circularBuffer.insert(1);

        assertThat(circularBuffer.getHead()).isEqualTo(0);
        assertThat(circularBuffer.getTail()).isEqualTo(0);

        circularBuffer.insert(2);
        circularBuffer.insert(3);
        assertThat(circularBuffer.getHead()).isEqualTo(0);
        assertThat(circularBuffer.getTail()).isEqualTo(2);
        circularBuffer.insert(4);

        assertThat(circularBuffer.getHead()).isEqualTo(0);
        assertThat(circularBuffer.getTail()).isEqualTo(3);


        circularBuffer.insert(5);
        assertThat(circularBuffer.getHead()).isEqualTo(1);
        assertThat(circularBuffer.getTail()).isEqualTo(4);


        circularBuffer.insert(5);
        assertThat(circularBuffer.getHead()).isEqualTo(2);
        assertThat(circularBuffer.getTail()).isEqualTo(5);
        circularBuffer.insert(5);
        assertThat(circularBuffer.getHead()).isEqualTo(3);
        assertThat(circularBuffer.getTail()).isEqualTo(6);
        circularBuffer.insert(5);
        assertThat(circularBuffer.getHead()).isEqualTo(4);
        assertThat(circularBuffer.getTail()).isEqualTo(7);
        circularBuffer.insert(5);
        assertThat(circularBuffer.getHead()).isEqualTo(5);
        assertThat(circularBuffer.getTail()).isEqualTo(8);
    }

    @Test
    void delete() {

        CircularBuffer circularBuffer = new CircularBuffer(4);
        circularBuffer.insert(1);
        circularBuffer.insert(2);
        circularBuffer.insert(3);
        circularBuffer.insert(4);
        assertThat(circularBuffer.delete()).isEqualTo(1);
        circularBuffer.insert(5);
        circularBuffer.insert(6);
        assertThat(circularBuffer.delete()).isEqualTo(3);
        assertThat(circularBuffer.delete()).isEqualTo(4);
        assertThat(circularBuffer.delete()).isEqualTo(5);
        assertThat(circularBuffer.delete()).isEqualTo(6);
        assertThat(circularBuffer.delete()).isEqualTo(6);
        assertThat(circularBuffer.delete()).isEqualTo(6);
        assertThat(circularBuffer.delete()).isEqualTo(6);
    }
}