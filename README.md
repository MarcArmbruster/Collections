# Collections

This repository tries to list well known collection types and  describes the each pros and cons of the different collection types.
The list may not contain all collection types of .NET 7, but most of it.

## Array
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

A good reference is:<br/> 
https://www.geeksforgeeks.org/c-sharp-array-vs-arraylist/?ref=lbp
### -> BitArray
### -> HashTable
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
 