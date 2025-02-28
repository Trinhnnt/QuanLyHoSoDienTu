package vn.edu.ueh.bit.core;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
public class Note {
    private long nodeId;
    private String note;
    private String deliveryAdd;
    private boolean isDelivery;

    public Note(long nodeId, String note, String deliveryAdd, boolean isDelivery) {
        this.nodeId = nodeId;
        this.note = note;
        this.deliveryAdd = deliveryAdd;
        this.isDelivery = isDelivery;
    }

    public long getNodeId() {
        return nodeId;
    }

    public void setNodeId(long nodeId) {
        this.nodeId = nodeId;
    }

    public String getNote() {
        return note;
    }

    public void setNote(String note) {
        this.note = note;
    }

    public String getDeliveryAdd() {
        return deliveryAdd;
    }

    public void setDeliveryAdd(String deliveryAdd) {
        this.deliveryAdd = deliveryAdd;
    }

    public boolean isDelivery() {
        return isDelivery;
    }

    public void setDelivery(boolean delivery) {
        isDelivery = delivery;
    }

    @Override
    public String toString() {
        return "Note{" +
                "nodeId=" + nodeId +
                ", note='" + note + '\'' +
                ", deliveryAdd='" + deliveryAdd + '\'' +
                ", isDelivery=" + isDelivery +
                '}';
    }
    public String toJson(){
        ObjectMapper mapper = new ObjectMapper();
        try {
            return mapper.writeValueAsString(this);
        } catch (JsonProcessingException e) {
            return "{\"error\": \"Failed to convert to JSON\"}";
        }
    }
}