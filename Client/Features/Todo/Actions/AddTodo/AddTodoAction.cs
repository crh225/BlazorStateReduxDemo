using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Client.Features.Todo
{

    using BlazorState;

    public partial class TodosState
    {
        public class AddTodoAction : IAction
        {
            public string chore { get; set; }
        }
    }
}
