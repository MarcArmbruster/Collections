# Collections

This repository tries to list well known collection types and  describes the each pros and cons of the different collection types.
The list may not contain all collection types of .NET 7, but most of it.

## -> Array
Array is the ultimate base for collection types and is still an important collection.
The class Array itself is an abstract base class you cannot instantiate directly.
But you can create arrays simply by using the  bracket notation.

example (array of strings)

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


## System.Collections
This namespace contains non-generic collection types.
### -> ArrayList
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

### -> BitArray
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

### -> HashTable
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


### -> Queue
### -> SortedList
### -> Stack

## System.Collections.Concurrent
### -> BlockingCollection
### -> ConcurrentBag
### -> ConcurrentDictionary
### -> ConcurrentQueue
### -> ConcurrentStack

## System.Collections.Generic
### -> Dictionary
### -> HashSet
### -> LinkedList
### -> List
### -> PriorityQueue
### -> Queue
### -> SortedDictionary
### -> SortedList
### -> SortedSet
### -> Stack

## System.Collections.Immutable
All immutable collections are provided as a generic and non-generic implementation!
### -> ImmutableArray
### -> ImmutableDictionary
### -> ImmutableHashSet
### -> ImmutableList
### -> ImmutableQueue
### -> ImmutableSortedDictionary
### -> ImmutableSortedSet
### -> ImmutableStack

## System.Collections.ObjectModel
### -> KeyedCollection
### -> ObservableCollection
see also ObservableCollectionExt of WpfCommandAggregator
### -> ReadOnlyDictionary
### -> ReadOnlyObservableCollection

## System.Collections.Specialized
### -> HybridDictionary
### -> ListDictionary
### -> NameValueCollection
### -> OrderedDictionary
### -> StringCollection
### -> StringDictionary
 