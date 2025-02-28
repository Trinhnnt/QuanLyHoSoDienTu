package vn.edu.ueh.bit.core;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;

public class Invoice {
    private long invoiceId;
    private long quantity;
    private String description;
    private long custId;
    private long productId;
    private long orderId;

    // Constructor mặc định
    public Invoice() {
    }

    // Constructor với đầy đủ tham số
    public Invoice(long invoiceId, long quantity, String description, long custId, long productId, long orderId) {
        this.invoiceId = invoiceId;
        this.quantity = quantity;
        this.description = description;
        this.custId = custId;
        this.productId = productId;
        this.orderId = orderId;
    }

    // Setters
    public void setQuantity(long quantity) {
        this.quantity = quantity;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public void setProductId(long productId) {
        this.productId = productId;
    }

    public void setInvoiceId(long invoiceId) {
        this.invoiceId = invoiceId;
    }

    public void setCustId(long custId) {
        this.custId = custId;
    }

    // Getters
    public long getInvoiceId() {
        return invoiceId;
    }

    public long getCustId() {
        return custId;
    }

    public long getQuantity() {
        return quantity;
    }

    public String getDescription() {
        return description;
    }

    public long getProductId() {
        return productId;
    }

    // Phương thức toString()
    @Override
    public String toString() {
        return "Invoice{" +
                "invoiceId=" + invoiceId +
                ", quantity=" + quantity +
                ", description='" + description + '\'' +
                ", custId=" + custId +
                ", productId=" + productId +
                ", orderId=" + orderId +
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