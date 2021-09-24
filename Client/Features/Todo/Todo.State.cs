using System.Collections.Generic;

namespace BlazorRedux.Client.Features.Todo
{
    using BlazorState;

    public partial class TodoState : State<TodoState>
    {
        public List<string> TheList { get; private set; }
        public override void Initialize() => TheList = new List<string>()
        {
            "Refactor into individual components", "Add remove button and actions"
        };
    }
}
