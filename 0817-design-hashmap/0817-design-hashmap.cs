public class MyHashMap {
    List<int> keys;
    List<int> vals;
    public MyHashMap() {
        keys=new();
        vals=new();
    }
    
    public void Put(int key, int value) {
        if(keys.Contains(key)){
            vals[keys.IndexOf(key)]=value;
        }
        else{
            keys.Add(key);
            vals.Add(value);
        }
    }
    
    public int Get(int key) {
        if(!keys.Contains(key)){
            return -1;
        }
        return vals[keys.IndexOf(key)];
    }
    
    public void Remove(int key) {
        if(!keys.Contains(key)){
            return;
        }
        vals.RemoveAt(keys.IndexOf(key));
        keys.Remove(key);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */