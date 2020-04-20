# Reflection
#### The source code in this repository demonstrates how to dynamically instantiate a class from a library(DLL) also loaded at runtime

When running this demo, you can configure the DLL file name and also the class name in app.config. For example:

<pre>
    (...)
    &lt;configuration&gt;
        (...)
        &lt;appSettings&gt;
            &lt;add key="dllPath"   value="<b>DLL_A.dll</b>" /&gt;
            &lt;add key="className" value="<b>ACME.Libraries.Example_A</b>" /&gt;
        &lt;/appSettings&gt;
    &lt;/configuration&gt;
    (...)
</pre>
or: 
<pre>
    (...)
    &lt;configuration&gt;
        (...)
        &lt;appSettings&gt;
            &lt;add key="dllPath"   value="<b>DLL_B.dll</b>" /&gt;
            &lt;add key="className" value="<b>ACME.Libraries.Example_B</b>" /&gt;
        &lt;/appSettings&gt;
    &lt;/configuration&gt;
    (...)
</pre>

Both classes **Example_A** and **Example_B** implement interface IExample, which defines a method **string Output()**

This kind of late binding allows more flexible software, where certain features can be freely changed at runtime – without recompilation –, by providing different "plug-in" classes compliant to a pre-defined interface. The interface to be accomplished establishes standard methods which can be implemented in many varied ways by those "plug-in" classes. For more details, refer to:
> MARTIN, Robert C. CLEAN ARCHITECTURE: A Craftsman's Guide To Software Structure And Design. USA, Pearson Education: 2018. ISBN-10 0-13-449416-4.

--------------------------------------------------------------------
