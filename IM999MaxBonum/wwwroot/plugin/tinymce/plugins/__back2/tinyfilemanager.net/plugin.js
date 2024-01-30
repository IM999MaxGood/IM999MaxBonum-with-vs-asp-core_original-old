//e->editor

tinymce.PluginManager.add('tinyfilemanager.net', function (e)
{
    function openmanager()
    {
        
        if (typeof __openmanager === "function") {
            __openmanager('all', e, '');
            return;
        }
        

        var win, data, dom = e.dom, imgElm = e.selection.getNode();
        var width, height, imageListCtrl;
        win = e.windowManager.open({
            title: 'File Manager',
            file: tfm_path + '/dialog.aspx?editor=' + e.id + '&lang=' + tinymce.settings.language,

            filetype: 'all',

            classes: 'tinyfilemanager.net',
            width: 900, height: 600, inline: 1
        })
    }


    e.addButton('tinyfilemanager.net', {
        icon: 'browse',
        tooltip: 'Insert file',
        onclick: openmanager, stateSelector: 'img:not([data-mce-object])'
    });
    e.addMenuItem('tinyfilemanager.net', {
        icon: 'browse', text: 'Insert file',
        onclick: openmanager, context: 'insert',
        prependToContext: true
    })
});