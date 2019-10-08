var TestPlugin = {
    ConsoleLog: function( label, num )
    {

		jsLog( Pointer_stringify(label), num );

    }
};

mergeInto(LibraryManager.library, TestPlugin);