public class MyHashSet {
    bool[] h;
    public MyHashSet() {
        h=new bool[10000001];
    }
    
    public void Add(int key) {
        h[key]=true;
    }
    
    public void Remove(int key) {
        h[key]=false;
    }
    
    public bool Contains(int key) {
        return h[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */