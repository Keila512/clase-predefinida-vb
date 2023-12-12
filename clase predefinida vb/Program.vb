Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Stack:")
        Dim stack As Stack(Of Integer) = New Stack(Of Integer)()
        stack.Push(1)
        stack.Push(2)
        stack.Push(3)

        While stack.Count > 0
            Dim poppedItem As Integer = stack.Pop()
            Console.WriteLine($"Stack element: {poppedItem}")
        End While

        Console.WriteLine(vbLf & "Queue:")
        Dim queue As Queue(Of String) = New Queue(Of String)()
        queue.Enqueue("First")
        queue.Enqueue("Second")
        queue.Enqueue("Third")

        While queue.Count > 0
            Dim dequeuedItem As String = queue.Dequeue()
            Console.WriteLine($"Queue element: {dequeuedItem}")
        End While

        Console.WriteLine(vbLf & "Linked Lists:")
        Dim linkedList As LinkedList(Of String) = New LinkedList(Of String)()
        linkedList.AddLast("Start")
        linkedList.AddLast("Half")
        linkedList.AddLast("End")

        For Each item As String In linkedList
            Console.WriteLine($"Linked list element: {item}")
        Next
    End Sub
End Module
