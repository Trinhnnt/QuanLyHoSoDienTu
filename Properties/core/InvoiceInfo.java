package vn.edu.ueh.bit.core;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import java.util.List;

public class InvoiceInfo {
    private List<Invoice> invoices;
    private List<CreditNote> creditNotes;
    private List<Payment> payments;
    private List<Note> notes;

    // Constructor mặc định
    public InvoiceInfo() {
    }

    // Constructor với đầy đủ tham số
    public InvoiceInfo(List<Invoice> invoices, List<CreditNote> creditNotes, List<Payment> payments, List<Note> notes) {
        this.invoices = invoices;
        this.creditNotes = creditNotes;
        this.payments = payments;
        this.notes = notes;
    }

    // Setters
    public void setInvoices(List<Invoice> invoices) {
        this.invoices = invoices;
    }

    public void setCreditNotes(List<CreditNote> creditNotes) {
        this.creditNotes = creditNotes;
    }

    public void setPayments(List<Payment> payments) {
        this.payments = payments;
    }

    public void setNotes(List<Note> notes) {
        this.notes = notes;
    }

    // Getters
    public List<Invoice> getInvoices() {
        return invoices;
    }

    public List<CreditNote> getCreditNotes() {
        return creditNotes;
    }

    public List<Payment> getPayments() {
        return payments;
    }

    public List<Note> getNotes() {
        return notes;
    }

    // Phương thức toString()
    @Override
    public String toString() {
        return "InvoiceInfo{" +
                "invoices=" + invoices +
                ", creditNotes=" + creditNotes +
                ", payments=" + payments +
                ", notes=" + notes +
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