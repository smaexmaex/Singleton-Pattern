using System;
using System.Runtime.InteropServices;

public sealed class Singleton
{
    // Eine private statische Instanz der Klasse, die später instanziiert wird.
    private static Singleton _instance = null;

    // Ein Objekt für thread-sichere Zugriffskontrolle.
    private static readonly object _lock = new object();

    // Privater Konstruktor, damit keine Instanzen von außen erstellt werden können.
    private Singleton()
    {
        Console.WriteLine("Singleton Instanz erstellt!");
    }

    // Öffentliche statische Methode, die die einzige Instanz der Klasse bereitstellt.
    public static Singleton Instance
    {
        get
        {
            // Thread-Sicherheit gewährleisten.
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }

    // Beispielmethode, die vom Singleton genutzt werden kann.
    public void DoSomething()
    {
        Console.WriteLine("Singleton Methode aufgerufen!");
    }

    // Methode zur Ausgabe der Speicheradresse
    public void PrintMemoryAddress()
    {
        // Handle erzeugen
        GCHandle handle = GCHandle.Alloc(this, GCHandleType.Pinned);
        IntPtr address = GCHandle.ToIntPtr(handle);

        Console.WriteLine($"Speicheradresse des Singleton-Objekts: {address}");

        // Handle wieder freigeben
        handle.Free();
    }
}
