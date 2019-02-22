namespace BlazorDemo.App.Services
{
    public class DragDropHelper
    {
        public DragItem Item { get; set; }

        public DragItem[] Items = new[]
        {
            new DragItem
            {
                Text = "Drag Item 1",
                Description = "foo",
                Index  = 1
            },
            new DragItem
            {
                Text = "Drag Item 2",
                Description = "bar",
                Index  = 1
            }
        };
    }
}
