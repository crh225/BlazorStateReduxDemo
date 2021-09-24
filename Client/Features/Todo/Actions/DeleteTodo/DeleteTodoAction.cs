using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Client.Features.Todo
{

    using BlazorState;

    public partial class TodosState
    {
        public class DeleteTodoAction : IAction
        {
            public string payload { get; set; }
        }
    }
}
