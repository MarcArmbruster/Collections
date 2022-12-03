# Collections

This repository tries to list well known collection types and  describes the each pros and cons of the different collection types.
The list may not contain all collection types of .NET 7, but most of it.

## Array
Array is the ultimate base for collection types and is still an important collection.
The class Array itself is an abstract base class you cannot instantiate directly.
But you can create arrays simply by using the  bracket notation.

example (array of strings)

One dimensional:

	string[] stringArray= new string[100];

Three dimensional:

	string[] stringArray= new string[20, 100, 50];


|Pros |Cons |
|:---|:---|
|:Arrays have a minimal overhead and therefore are very fast and has low energy consumption by default.|Arrays has a very low usage comfort. |


## System.Collections
This namespace contains non-generic collection types.
### -> ArrayList
>ArrayList is ...
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
 