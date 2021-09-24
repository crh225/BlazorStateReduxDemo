using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Client.Features.Todo
{

    using BlazorState;

    public partial class TodoState
    {
        public class AddTodoAction : IAction
        {
            public string payload { get; set; }
        }
    }
}
