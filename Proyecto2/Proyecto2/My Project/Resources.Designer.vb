﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Proyecto2.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property itextsharp_pdfa() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("itextsharp_pdfa", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property itextsharp_xtra() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("itextsharp_xtra", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot;?&gt;
        '''&lt;doc&gt;
        '''    &lt;assembly&gt;
        '''        &lt;name&gt;itextsharp&lt;/name&gt;
        '''    &lt;/assembly&gt;
        '''    &lt;members&gt;
        '''        &lt;member name=&quot;T:iTextSharp.text.Anchor&quot;&gt;
        '''            &lt;summary&gt;
        '''            An Anchor can be a reference or a destination of a reference.
        '''            &lt;/summary&gt;
        '''            &lt;remarks&gt;
        '''            An Anchor is a special kind of &lt;see cref=&quot;T:iTextSharp.text.Phrase&quot;/&gt;.
        '''            It is constructed in the same way.
        '''            &lt;/remarks&gt;
        '''            &lt;seealso cref=&quot;T:iTextSharp.text.Eleme [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property iTextSharp1() As String
            Get
                Return ResourceManager.GetString("iTextSharp1", resourceCulture)
            End Get
        End Property
    End Module
End Namespace