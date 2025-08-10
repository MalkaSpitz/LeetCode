public class MyHashSet {
    List<int> h;
    public MyHashSet() {
        h=new();
    }
    
    public void Add(int key) {
        if(h.Contains(key)) 
            return;
        h.Add(key);
    }
    
    public void Remove(int key) {
        if(h.Contains(key))
            h.Remove(key);
    }
    
    public bool Contains(int key) {
        return h.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */