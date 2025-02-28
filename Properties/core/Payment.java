package vn.edu.ueh.bit.core;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;

public class Payment {
    private long paymentId;
    private long custId;
    private String cvv;
    private String cardNumber;

    // Constructor mặc định
    public Payment() {
    }

    // Constructor với đầy đủ tham số
    public Payment(long paymentId, long custId, String cvv, String cardNumber) {
        this.paymentId = paymentId;
        this.custId = custId;
        this.cvv = cvv;
        this.cardNumber = cardNumber;
    }

    // Setters
    public void setCustId(long custId) {
        this.custId = custId;
    }

    public void setPaymentId(long paymentId) {
        this.paymentId = paymentId;
    }

    public void setCvv(String cvv) {
        this.cvv = cvv;
    }

    public void setCardNumber(String cardNumber) {
        this.cardNumber = cardNumber;
    }

    // Getters
    public long getPaymentId() {
        return paymentId;
    }

    public long getCustId() {
        return custId;
    }

    public String getCvv() {
        return cvv;
    }

    public String getCardNumber() {
        return cardNumber;
    }

    // Phương thức toString()
    @Override
    public String toString() {
        return "Payment{" +
                "paymentId=" + paymentId +
                ", custId=" + custId +
                ", cvv='" + cvv + '\'' +
                ", cardNumber='" + cardNumber + '\'' +
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