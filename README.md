# WYSWYG
Simple Text Editor for MVC C# with Image 


Integration of Summernote WYSWYG Editor with MVC C#


Features :

# WYSWYG - What You See What You get Editor
#Image Upload Feature
# No need of multiple columns of data
#Image is stored as base 64 txt


Credits To :
http://summernote.org/
http://www.haneefputtur.com/


Steps for installation


# Create this model

public class News
        {
            public string Title { get; set; }
            [AllowHtml]
            public string Content { get; set; }
            
        }
		


Copy the folder Summernote to Scripts folder

# Include these references in the view where you need the editor

<link href="~/Scripts/summernote/summernote.css" rel="stylesheet" />
<script src="~/Scripts/summernote/summernote.js"></script>

Note That Jquery references in Layout file is moved above header so that jquery is included before summernote.

# Add below script to the image for initializing
<script>
    //$(document).ready(function () {
    //    $('#Content').summernote();
    //});

    $('#Content').summernote({
        height: 300,                 // set editor height
        minHeight: null,             // set minimum height of editor
        maxHeight: null,             // set maximum height of editor
        focus: true                  // set focus to editable area after initializing summernote
    });

</script>

#### For any suggestion on improvements please reach me at haneef@haneefputtur.com  ############
