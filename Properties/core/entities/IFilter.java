package vn.edu.ueh.bit.core.entities;

public interface IFilter <T> {
    T process(T input);
}
