var pq = new PriorityQueue<string, int>();
pq.Enqueue("Christian", 3);
pq.Enqueue("Annalena", 2);
pq.Enqueue("Olaf", 1);
pq.Enqueue("Robert", 2);
pq.Enqueue("Armin", 5);
pq.Enqueue("Janine", 3);
pq.Enqueue("Susanne", 3);
while (pq.TryDequeue(out var name, out int prio))
{
 Console.WriteLine($"Name: {name} - Prio: {prio}");
}