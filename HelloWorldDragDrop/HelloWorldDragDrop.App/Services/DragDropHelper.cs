namespace HelloWorldDragDrop.App.Services
{
    public static class DragDropHelper
    {
        public static DragItem[] Items = new[]
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

        public static DragItem Item { get; set; }
    }
}
