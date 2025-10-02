# Binary Search Tree (Arbore Binar de Cautare)

## Descriere

Acest proiect implementeaza un **Arbore Binar de Cautare (BST - Binary Search Tree)** in C# (.NET 8). Un BST este o structura de date arborescenta in care fiecare nod are maxim doi copii (stang si drept), cu proprietatea fundamentala ca:

- Toate valorile din subarborele stang sunt mai mici decat valoarea nodului curent
- Toate valorile din subarborele drept sunt mai mari decat valoarea nodului curent

## Cum functioneaza?

### Structura

Fiecare nod al arborelui contine:
- **Value**: valoarea intreaga stocata in nod
- **Left**: referinta catre copilul stang (null daca nu exista)
- **Right**: referinta catre copilul drept (null daca nu exista)

### Operatii principale

#### 1. Insert (Inserare)
Adauga o valoare noua in arbore, mentinand proprietatea BST:
- Daca arborele este gol, noul nod devine radacina
- Daca valoarea este mai mica decat nodul curent, se insereaza in subarborele stang
- Daca valoarea este mai mare, se insereaza in subarborele drept
- Complexitate: O(log n) in cazul mediu, O(n) in cazul cel mai defavorabil

#### 2. Search (Cautare)
Cauta o valoare in arbore:
- Compara valoarea cautata cu nodul curent
- Daca sunt egale, valoarea a fost gasita
- Daca valoarea cautata este mai mica, cauta in subarborele stang
- Daca valoarea cautata este mai mare, cauta in subarborele drept
- Complexitate: O(log n) in cazul mediu, O(n) in cazul cel mai defavorabil

#### 3. Delete (Stergere)
Sterge o valoare din arbore, avand trei cazuri:
- **Nod fara copii (frunza)**: se sterge direct
- **Nod cu un singur copil**: nodul este inlocuit cu copilul sau
- **Nod cu doi copii**: nodul este inlocuit cu succesorul inorder (cea mai mica valoare din subarborele drept)
- Complexitate: O(log n) in cazul mediu, O(n) in cazul cel mai defavorabil

### Traversari (Parcurgeri)

Arborele poate fi parcurs in trei moduri:

1. **In-Order (Stanga-Radacina-Dreapta)**
   - Afiseaza valorile in ordine crescatoare
   - Ordine: copil stang → nod curent → copil drept

2. **Pre-Order (Radacina-Stanga-Dreapta)**
   - Utila pentru copierea arborelui
   - Ordine: nod curent → copil stang → copil drept

3. **Post-Order (Stanga-Dreapta-Radacina)**
   - Utila pentru stergerea arborelui
   - Ordine: copil stang → copil drept → nod curent

## Avantaje si dezavantaje

### Avantaje:
- Cautare, inserare si stergere eficiente in cazul mediu: O(log n)
- Mentine datele ordonate
- Structura simpla si intuitiva

### Dezavantaje:
- In cazul cel mai defavorabil (arbore degenerat/liniara), operatiile devin O(n)
- Nu este autoechilibrat (exista variante precum AVL Tree sau Red-Black Tree pentru echilibrare)

## Rulare

```bash
dotnet run
```

Programul va demonstra toate operatiile BST: inserare, cautare, stergere si diferite tipuri de parcurgeri.