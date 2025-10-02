using TreesStructures.DataStructures;

Console.WriteLine("=== Binary Search Tree Demonstration ===\n");

// Create a new Binary Search Tree
var bst = new BinarySearchTree();

// Insert values
Console.WriteLine("Inserting values: 50, 30, 70, 20, 40, 60, 80");
bst.Insert(50);
bst.Insert(30);
bst.Insert(70);
bst.Insert(20);
bst.Insert(40);
bst.Insert(60);
bst.Insert(80);

// Display the tree using different traversal methods
Console.WriteLine("\nIn-Order Traversal (sorted order):");
bst.InOrderTraversal();

Console.WriteLine("Pre-Order Traversal:");
bst.PreOrderTraversal();

Console.WriteLine("Post-Order Traversal:");
bst.PostOrderTraversal();

// Search for values
Console.WriteLine("\n--- Search Operations ---");
int searchValue = 40;
Console.WriteLine($"Searching for {searchValue}: {(bst.Search(searchValue) ? "Found" : "Not Found")}");

searchValue = 25;
Console.WriteLine($"Searching for {searchValue}: {(bst.Search(searchValue) ? "Found" : "Not Found")}");

// Delete operations
Console.WriteLine("\n--- Delete Operations ---");

// Delete a leaf node
Console.WriteLine("Deleting 20 (leaf node)");
bst.Delete(20);
Console.Write("In-Order Traversal after deletion: ");
bst.InOrderTraversal();

// Delete a node with one child
Console.WriteLine("Deleting 30 (node with one child)");
bst.Delete(30);
Console.Write("In-Order Traversal after deletion: ");
bst.InOrderTraversal();

// Delete a node with two children
Console.WriteLine("Deleting 50 (node with two children - root)");
bst.Delete(50);
Console.Write("In-Order Traversal after deletion: ");
bst.InOrderTraversal();

Console.WriteLine("\n=== Demonstration Complete ===");