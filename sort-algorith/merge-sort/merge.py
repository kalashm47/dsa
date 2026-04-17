class Merge:
    
    @staticmethod
    def copy_array(a: list[int], begin: int, end: int, b: list[int]) -> None:
       
        for k in range(begin, end):
            b[k] = a[k]
            
            
        
    @staticmethod    
    def top_down_merge(a: list[int], begin: int, middle: int, end: int, b: list[int]) -> None: 
        i: int = begin
        j: int = middle 
        
        for k in range(begin, end):
            if i < middle and (j >= end or a[i] <= a[j]):
                b[k] = a[i]
                i += 1
            else:
                b[k] = a[j]
                j += 1
                
    @staticmethod                     
    def top_down_split_merge(a: list[int], begin: int, end: int, b: list[int]):
        if end - begin <=1:
            return
        
        middle: int  = (begin + end) // 2
        Merge.top_down_split_merge(b, begin, middle, a)
        Merge.top_down_split_merge(b, middle, end, a)
        
        Merge.top_down_merge(b, begin, middle, end, a)
        
    @staticmethod
    def top_down_merge_sort(a: list[int]) -> list[int]:
        
        b = a.copy()
        Merge.copy_array(a, 0, len(a), b)
        Merge.top_down_split_merge(b, 0, len(a), a)
        return a
    
if __name__ == "__main__":
    arr = [38, 27, 43, 3, 9, 82, 10]
    
    print("Original:", arr)
    
    sorted_arr = Merge.top_down_merge_sort(arr)
    
    print("Ordenado:", sorted_arr)