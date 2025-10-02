### c# syntax

# Planul de kata (7–10 sesiuni)

## Sesiunea 1 — Warm-up & Big-O rapid

1. Creează un repo “csharp-kata”.
2. Scrie o funcție `IndexOfLinear<T>(IList<T> list, T value)` (căutare liniară).
3. Scrie `BinarySearch` pentru `List<int>` sortată.
4. Notează Big-O: `IndexOfLinear` = **O(n)**, `BinarySearch` = **O(log n)**.
5. Mini-benchmark (estimezi empiric; ulterior folosim BenchmarkDotNet).

De ce: Autorul *tools and skills* subliniază că a înțelege **Big-O** & co. este fundație pentru evaluarea eficienței, cu tabele clare pentru O(1), O(n), O(log n), O(n log n), O(n²), O(2ⁿ) și exemple (array index → O(1), căutare nesortată → O(n), mergesort/heapsort → O(n log n), etc.). 

---

## Sesiunea 2 — Colecții BCL vs implementare „de mână”

1. Folosește `Queue<T>` și `Stack<T>` cu operațiile de bază (`Enqueue/Dequeue`, `Push/Pop`, `Peek`) ca să internalizezi API-ul standard.
2. Implementează „de mână” o coadă și un stack peste o listă înlănțuită simplă (Singly Linked List).

Tips: *Head First C#* explică foarte clar FIFO/LIFO, cum le folosești și cum toate implementează `IEnumerable<T>` (util pentru `foreach`).

Big-O:

* `Queue<T>`, `Stack<T>`: **O(1)** amortizat la operațiile principale.
* Implementarea ta: urmărește să fie **O(1)** pentru `Enqueue` (coadă cu coadă + coadă de tail).

---

## Sesiunea 3 — Dynamic array & dicționar

1. Implementează un „`Vector<T>`” (dynamic array): dublare capacitate la overflow.

   * `Add`: **amortizat O(1)**; `Insert(i)`: **O(n)**; `IndexOf`: **O(n)**.
2. Scrie un mini hash table `MyHashMap<K,V>` (open addressing sau chaining).

   * Explică: **O(1)** average / **O(n)** worst-case; rehash la factor de încărcare.

Legătura cu producția: în practică vei folosi colecțiile BCL (`List<T>`, `Dictionary<,>`), dar *tools and skills* insistă că e valoros să înțelegi **mecanica** și când să le aplici (sorting/searching/data-structure/hash/recursion).

---

## Sesiunea 4 — Arborescențe

1. Implementează un **BST** (insert, find, delete).
2. Traversează **In-order/Pre-order/Post-order**.
3. Adaugă `Height()` și `IsBalanced()`.

Big-O:

* Căutare/insert/delete: **O(h)**; **O(log n)** pe arbori balanțați, **O(n)** în worst-case degenerat.
  *tools and skills* recomandă explicit „Tree traversal” și algoritmi pe grafuri ca fundament. 

---

## Sesiunea 5 — Grafuri, BFS/DFS & Dijkstra

1. Graf neorientat cu `List<int>[]` adjacency.
2. **BFS** (coadă) pentru distanță minimă în muchii neponderate → **O(V+E)**.
3. **DFS** recursiv/iterativ → **O(V+E)**.
4. **Dijkstra** (min-heap) pentru ponderi pozitive → **O(E log V)**.

Referință: capitolul cu algoritmi menționează BFS/DFS și Dijkstra ca piese importante pentru .NET devs. 

---

## Sesiunea 6 — Sortări

1. Implementează **Quicksort** (median-of-three), **Mergesort** și (pentru antrenament) **Bubblesort**.
2. Notează Big-O:

   * QuickSort: best/avg **O(n log n)**, worst **O(n²)** (pivot rău).
   * MergeSort: **O(n log n)** timp, **O(n)** spațiu.
   * Bubble: **O(n²)**.
     *tools and skills* listează clar sortările recomandate și diferențele. 

---

## Sesiunea 7 — Recursie & transformări

1. **Backtracking** simplu (generare permutări) — evidențiază **O(n!)**.
2. **Divide-and-conquer** pe un exercițiu mic (ex. număr de inversiuni cu mergesort).
3. Discută pericolul recursiei: stack usage și alternative iterative. (și autorul avertizează că recursia poate complica mentenanța). 

---

## Sesiunea 8 — Big-O în practică cu BenchmarkDotNet

1. Creează un proiect `BenchmarkDotNet` și compară:

   * `List<T>.Contains` pe liste de mărimi crescătoare (așteaptă **O(n)**).
   * `HashSet<T>.Contains` (așteaptă **O(1)** average).
   * Căutare liniară vs. binary search pe array sortat.
2. Plotează rezultatele vs. n și verifică pantele (lin/log/lin-log).

Cartea are capitol dedicat **benchmarking-ului**, Big-O și bune practici (izolare setup, baseline, capcane de măsurare). Include și exerciții despre Big-O și linkuri către BenchmarkDotNet.

---

## Sesiunea 9 — Interviu-style drills (LeetCode-ish)

Alege 5–8 probleme (two-sum, valid-parentheses, merge intervals, LRU cache, level-order traversal, etc.). Pentru fiecare:

* descrie soluția în 1–2 propoziții,
* scrie test(e) rapide,
* notează Big-O timp/spațiu, plus trade-off.

*tools and skills* sugerează explicit platforme precum LeetCode/HackerRank pentru antrenament. 

---

## Sesiunea 10 — Recap + idiomuri C#

* Refactor: folosește **pattern matching** și **`scoped`**/`using` unde are sens.
* Compară „de mână” vs BCL (ex. `Dictionary`, `PriorityQueue<TPriority,TItem>`, `Span<T>` acolo unde e relevant).
* Întărește „când aș alege X în producție vs. Y ca exercițiu”.

---

# Cum identifici rapid Big-O (șabloane mentale)

* **Buclă simplă peste n** elemente → **O(n)**.
* **Buclă imbricată** cu n în ambele bucle → **O(n²)** (ex.: dublu `for` pentru compararea tuturor perechilor).
* **Divide & Conquer** (împarți în 2 și combini în O(n)) → **T(n)=2T(n/2)+O(n)** → **O(n log n)** (mergesort).
* **Dublare/înmulțire constantă a muncii per element** → **O(2ⁿ)** (subsete brute-force).
* **Reduci la jumătate spațiul de căutare** (binary search) → **O(log n)**.
* **Structuri de hashing**: operații average **O(1)**, worst **O(n)** (coliziuni severe).
* **Arbori balanțați / heap**: operații tipice **O(log n)** (căutare/insert/erase, `ExtractMin`).

Cartea *tools and skills* are tabele gata-făcute pentru Big-O + explicații legate de spațiu și notațiile Θ/Ω (ajută să vorbești „corect” la interviu).

---

# De ce merită să faci asta în C#

* BCL acoperă deja **sorting/searching/colecții**; în producție folosești **implementările standard**, dar înțelegerea internals te face mai bun în diagnoză/optimizare (cartea insistă pe asta).
* *Head First C#* e excelent pentru a „simți” colecțiile (Queue/Stack/List/Dictionary) prin exemple concrete și mini-proiecte, plus un **Appendix „Code Kata”** cu traseu rapid pentru devs cu experiență (poți alterna cu planul de mai sus).

---
