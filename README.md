# Overview and short discussion of C# collections

This repository tries to list well known collection types and  describes the each pros and cons of the different collection types.
The list may not contain all collection types of **.NET 7**, but most of it.

Base Collection
- Array

Non-Generic Collections
- ArrayList
- BitArray
- HashTable
- Queue
- SortedList
- Stack

System.Collections.Concurrent
- BlockingCollection
- ConcurrentBag
- ConcurrentDictionary
- ConcurrentQueue
- ConcurrentStack

System.Collections.Generic
- Dictionary
- HashSet
- LinkedList
- List
- PriorityQueue
- Queue
- SortedDictionary
- SortedList
- SortedSet
- Stack

System.Collections.Immutable
- ImmutableArray
- ImmutableDictionary
- ImmutableHashSet
- ImmutableList
- ImmutableQueue
- ImmutableSortedDictionary
- ImmutableSortedSet
- ImmutableStack

System.Collections.ObjectModel
- KeyedCollection
- ObservableCollection
- ReadOnlyDictionary
- ReadOnlyObservableCollection

System.Collections.Specialized
- HybridDictionary
- ListDictionary
- NameValueCollection
- OrderedDictionary
- StringCollection
- StringDictionary

# The collections in more detail

## 0. Array
>Array is the ultimate base for collection types and is still an important collection.
>The class Array itself is an abstract base class you cannot instantiate directly.
>But you can create arrays simply by using the  bracket notation.

Example:<br/>
One dimensional:
```
string[] stringArray= new string[100];
```
Three dimensional:
```
string[] stringArray= new string[20, 100, 50];
```

|Pros |Cons |
|:---|:---|
|Arrays have a minimal overhead and therefore are very fast and has low energy consumption by default.|Arrays has a very low usage comfort. |

><a href="https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/">Array on MS Learn<a>


## System.Collections
This namespace contains non-generic collection types.
### 1. ArrayList
>An ArrayList works similar to an array, but manages its size itself by adding/removing items.
>An important difference is the possibility to store items of different types into the same instance of an ArrayList.

Example:<br/>
```
ArrayList list = new ArrayList();
list.Add("one");
list.Add(5);
list.Add(7.45m);
```

|Pros |Cons |
|:---|:---|
|More dynamic than an array|Add/Remove slower than an Array (due to resizing)|
|Can contain different types|Maybe requires casting due to non typed data|

### 2. BitArray
>A BitArray is a specialized array to manage boolean values.
>A BitArray provides built-in support for logical operations like And, Or, Not, Xor, Shift ....

Example:<br/>
```
BitArray bitArray = new BitArray(5, true);
bitArray.Not(); // switch all 5 flags from true to false
```

|Pros |Cons |
|:---|:---|
|Comfortable logic functions|No support of nullable booleans|

### 3. HashTable
>A hashtable manages key-value pairs, where both key and value can be of any type. Keys must have a unique hash value.

Example:<br/>
```
Hashtable hashtable = new Hashtable();
hashtable.Add("key1", "any value");
hashtable.Add(1m, "value1m");
hashtable.Add((int)1, 345.6456m);
```

|Pros |Cons |
|:---|:---|
|Supports any type and cross type keys|For big data amounts the HashTable has lower performance than a generic Dictionary<T,K>|

### 4. Queue
>A (non-generic) Queue represents a first in-first out implementation for mixed types.
>It can be used as a working buffer and therefore can avoid blocking situations and a decoupling of sender and receiver.

Example:<br/>
```
Queue queue = new Queue();
queue.Enqueue(1);
queue.Enqueue("zwei");
queue.Enqueue(3m);
```

|Pros |Cons |
|:---|:---|
|Easy first in-first out collection for any (mixed) type of data|Not type safe. Requires type analyzation and/or casting|


### 5. SortedList

>A (non-generic) SortedList works similar to a collection of Key-Value-Pairs..
>The great advantage is the automatic sorting of the entries by key values.
>For mixed type keys an individual comparer can be used.

Example:<br/>
```
IComparer comparer = new NumericComparer();

SortedList sortedList = new SortedList(comparer);
sortedList.Add(2, "two");
sortedList.Add(4L, "four");
sortedList.Add("1", 1);
sortedList.Add(3m, 3m);

Assert.AreEqual(1, sortedList.GetByIndex(0));
Assert.AreEqual("two", sortedList.GetByIndex(1));
Assert.AreEqual(3m, sortedList.GetByIndex(2));
Assert.AreEqual("four", sortedList.GetByIndex(3));
```

|Pros |Cons |
|:---|:---|
|A good choice if you need an automatic sorted collection|Sorting is represented by a lower performance than some other collections|
|Custom Comparers can be used, especially for mixedtypes|-|

### 6. Stack
>Represents a very simple last-in-first-out non-generic collection of objects.
Example:<br/>
```
Stack stack = new Stack();
stack.Push("One");
stack.Push(2m);
stack.Push(3L);

Assert.AreEqual(3L, stack.Pop());
Assert.AreEqual(2m, stack.Pop());
Assert.AreEqual("One", stack.Pop());
```

|Pros |Cons |
|:---|:---|
|Very simple to use|Throws an exceptio on Pop() if collection is empty|


## System.Collections.Concurrent
### 7. BlockingCollection

<a href="https://learn.microsoft.com/en-us/dotnet/standard/collections/thread-safe/blockingcollection-overview">BlockingCollection on MS Learn<a>

### 8. ConcurrentBag
todo
### 9. ConcurrentDictionary
todo
### 10. ConcurrentQueue
todo
### 11. ConcurrentStack
todo

## System.Collections.Generic
### 12. Dictionary
todo
### 13. HashSet
todo
### 14. LinkedList
todo
### 15. List
todo
### 16. PriorityQueue
todo
### 17. Queue
todo
### 18. SortedDictionary
todo
### 19. SortedList
todo
### 20. SortedSet
todo
### 21. Stack
todo

## System.Collections.Immutable
All immutable collections are provided as a generic and non-generic implementation!
### 22. ImmutableArray
todo
### 23. ImmutableDictionary
todo
### 24. ImmutableHashSet
todo
### 25. ImmutableList
todo
### 26. ImmutableQueue
todo
### 27. ImmutableSortedDictionary
todo
### 28. ImmutableSortedSet
todo
### 29. ImmutableStack
todo

## System.Collections.ObjectModel
### 30. KeyedCollection
todo
### 31. ObservableCollection
see also ObservableCollectionExt of WpfCommandAggregator
todo
### 32. ReadOnlyDictionary
todo
### 33. ReadOnlyObservableCollection
todo

## System.Collections.Specialized
### 34. HybridDictionary
todo
### 35. ListDictionary
todo
### 36. NameValueCollection
todo
### 37. OrderedDictionary
todo
### 38. StringCollection
todo
### 39. StringDictionary
todo
 