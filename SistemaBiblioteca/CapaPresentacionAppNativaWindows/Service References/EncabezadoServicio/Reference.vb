﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.17929
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace EncabezadoServicio
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="DEncabezado", [Namespace]:="http://schemas.datacontract.org/2004/07/ServiciosWeb"),  _
     System.SerializableAttribute()>  _
    Partial Public Class DEncabezado
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private DescripcionField As String
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private IdEncabezadoField As System.Guid
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Descripcion() As String
            Get
                Return Me.DescripcionField
            End Get
            Set
                If (Object.ReferenceEquals(Me.DescripcionField, value) <> true) Then
                    Me.DescripcionField = value
                    Me.RaisePropertyChanged("Descripcion")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property IdEncabezado() As System.Guid
            Get
                Return Me.IdEncabezadoField
            End Get
            Set
                If (Me.IdEncabezadoField.Equals(value) <> true) Then
                    Me.IdEncabezadoField = value
                    Me.RaisePropertyChanged("IdEncabezado")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="EncabezadoServicio.IEncabezadoServicio")>  _
    Public Interface IEncabezadoServicio
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/DoWork", ReplyAction:="http://tempuri.org/IEncabezadoServicio/DoWorkResponse")>  _
        Sub DoWork()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/DoWork", ReplyAction:="http://tempuri.org/IEncabezadoServicio/DoWorkResponse")>  _
        Function DoWorkAsync() As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/Guardar", ReplyAction:="http://tempuri.org/IEncabezadoServicio/GuardarResponse")>  _
        Sub Guardar(ByVal Encabezado As EncabezadoServicio.DEncabezado)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/Guardar", ReplyAction:="http://tempuri.org/IEncabezadoServicio/GuardarResponse")>  _
        Function GuardarAsync(ByVal Encabezado As EncabezadoServicio.DEncabezado) As System.Threading.Tasks.Task
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/Lista", ReplyAction:="http://tempuri.org/IEncabezadoServicio/ListaResponse")>  _
        Function Lista() As System.Collections.Generic.List(Of EncabezadoServicio.DEncabezado)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/Lista", ReplyAction:="http://tempuri.org/IEncabezadoServicio/ListaResponse")>  _
        Function ListaAsync() As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of EncabezadoServicio.DEncabezado))
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/BuscarPorDescripcion", ReplyAction:="http://tempuri.org/IEncabezadoServicio/BuscarPorDescripcionResponse")>  _
        Function BuscarPorDescripcion(ByVal Descripcion As String) As EncabezadoServicio.DEncabezado
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/BuscarPorDescripcion", ReplyAction:="http://tempuri.org/IEncabezadoServicio/BuscarPorDescripcionResponse")>  _
        Function BuscarPorDescripcionAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of EncabezadoServicio.DEncabezado)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/Existe", ReplyAction:="http://tempuri.org/IEncabezadoServicio/ExisteResponse")>  _
        Function Existe(ByVal Descripcion As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEncabezadoServicio/Existe", ReplyAction:="http://tempuri.org/IEncabezadoServicio/ExisteResponse")>  _
        Function ExisteAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of Boolean)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IEncabezadoServicioChannel
        Inherits EncabezadoServicio.IEncabezadoServicio, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class EncabezadoServicioClient
        Inherits System.ServiceModel.ClientBase(Of EncabezadoServicio.IEncabezadoServicio)
        Implements EncabezadoServicio.IEncabezadoServicio
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Sub DoWork() Implements EncabezadoServicio.IEncabezadoServicio.DoWork
            MyBase.Channel.DoWork
        End Sub
        
        Public Function DoWorkAsync() As System.Threading.Tasks.Task Implements EncabezadoServicio.IEncabezadoServicio.DoWorkAsync
            Return MyBase.Channel.DoWorkAsync
        End Function
        
        Public Sub Guardar(ByVal Encabezado As EncabezadoServicio.DEncabezado) Implements EncabezadoServicio.IEncabezadoServicio.Guardar
            MyBase.Channel.Guardar(Encabezado)
        End Sub
        
        Public Function GuardarAsync(ByVal Encabezado As EncabezadoServicio.DEncabezado) As System.Threading.Tasks.Task Implements EncabezadoServicio.IEncabezadoServicio.GuardarAsync
            Return MyBase.Channel.GuardarAsync(Encabezado)
        End Function
        
        Public Function Lista() As System.Collections.Generic.List(Of EncabezadoServicio.DEncabezado) Implements EncabezadoServicio.IEncabezadoServicio.Lista
            Return MyBase.Channel.Lista
        End Function
        
        Public Function ListaAsync() As System.Threading.Tasks.Task(Of System.Collections.Generic.List(Of EncabezadoServicio.DEncabezado)) Implements EncabezadoServicio.IEncabezadoServicio.ListaAsync
            Return MyBase.Channel.ListaAsync
        End Function
        
        Public Function BuscarPorDescripcion(ByVal Descripcion As String) As EncabezadoServicio.DEncabezado Implements EncabezadoServicio.IEncabezadoServicio.BuscarPorDescripcion
            Return MyBase.Channel.BuscarPorDescripcion(Descripcion)
        End Function
        
        Public Function BuscarPorDescripcionAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of EncabezadoServicio.DEncabezado) Implements EncabezadoServicio.IEncabezadoServicio.BuscarPorDescripcionAsync
            Return MyBase.Channel.BuscarPorDescripcionAsync(Descripcion)
        End Function
        
        Public Function Existe(ByVal Descripcion As String) As Boolean Implements EncabezadoServicio.IEncabezadoServicio.Existe
            Return MyBase.Channel.Existe(Descripcion)
        End Function
        
        Public Function ExisteAsync(ByVal Descripcion As String) As System.Threading.Tasks.Task(Of Boolean) Implements EncabezadoServicio.IEncabezadoServicio.ExisteAsync
            Return MyBase.Channel.ExisteAsync(Descripcion)
        End Function
    End Class
End Namespace
