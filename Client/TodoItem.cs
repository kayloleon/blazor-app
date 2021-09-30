using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// creates class which is later used in Todo.razor when making to do list
// this class represents each item in the to do list
public class TodoItem
{
    // item Title given by user in Todo.razor
    public string Title { get; set; }

    // Tells if item is checked, given by user in Todo.razor
    public bool IsDone { get; set; }

}
