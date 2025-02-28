package vn.edu.ueh.bit.core;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import vn.edu.ueh.bit.core.entities.IMessage;

public class Message implements IMessage {
    private String fileContent;
    private InvoiceInfo invoiceInfo;

    // Constructor mặc định
    public Message() {
    }

    // Constructor với đầy đủ tham số
    public Message(String fileContent, InvoiceInfo invoiceInfo) {
        this.fileContent = fileContent;
        this.invoiceInfo = invoiceInfo;
    }

    // Setters
    public void setFileContent(String fileContent) {
        this.fileContent = fileContent;
    }

    public void setInvoiceInfo(InvoiceInfo invoiceInfo) {
        this.invoiceInfo = invoiceInfo;
    }

    // Getters
    public String getFileContent() {
        return fileContent;
    }

    public InvoiceInfo getInvoiceInfo() {
        return invoiceInfo;
    }

    // Phương thức toString()
    @Override
    public String toString() {
        return "Message{" +
                "fileContent='" + fileContent + '\'' +
                ", invoiceInfo=" + invoiceInfo +
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

    // Triển khai phương thức getMessage() từ IMessage
    @Override
    public String getMessage() {
        return fileContent != null ? fileContent : "No message content";
    }
}