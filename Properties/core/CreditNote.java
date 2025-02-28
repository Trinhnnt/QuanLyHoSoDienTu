package vn.edu.ueh.bit.core;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;

public class CreditNote {
    private long creditNote;
    private String notes;
    private boolean cancellation;

    // Constructor mặc định
    public CreditNote() {
    }

    // Constructor với đầy đủ tham số
    public CreditNote(long creditNote, String notes, boolean cancellation) {
        this.creditNote = creditNote;
        this.notes = notes;
        this.cancellation = cancellation;
    }

    // Setters
    public void setCreditNote(long creditNote) {
        this.creditNote = creditNote;
    }

    public void setNotes(String notes) {
        this.notes = notes;
    }

    public void setCancellation(boolean cancellation) {
        this.cancellation = cancellation;
    }

    // Getters
    public long getCreditNote() {
        return creditNote;
    }

    public String getNotes() {
        return notes;
    }

    // Phương thức isCancellation()
    public boolean isCancellation() {
        return cancellation;
    }

    // Phương thức toString()
    @Override
    public String toString() {
        return "CreditNote{" +
                "creditNote=" + creditNote +
                ", notes='" + notes + '\'' +
                ", cancellation=" + cancellation +
                '}';
    }

    // Phương thức toJson() (sử dụng Jackson)
    public String toJson() {
        ObjectMapper mapper = new ObjectMapper();
        try {
            return mapper.writeValueAsString(this);
        } catch (JsonProcessingException e) {
            return "{\"error\": \"Failed to convert to JSON\"}";
        }
    }
}