// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/image.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcImage {
  public static partial class ProcessImage
  {
    static readonly string __ServiceName = "ProcessImage";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcImage.ProcessImageRequest> __Marshaller_ProcessImageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcImage.ProcessImageRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcImage.ProcessImageReply> __Marshaller_ProcessImageReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcImage.ProcessImageReply.Parser));
    static readonly grpc::Marshaller<global::GrpcImage.CreateEncodingRequest> __Marshaller_CreateEncodingRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcImage.CreateEncodingRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcImage.CreateEncodingReply> __Marshaller_CreateEncodingReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcImage.CreateEncodingReply.Parser));
    static readonly grpc::Marshaller<global::GrpcImage.DeleteEncodingRequest> __Marshaller_DeleteEncodingRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcImage.DeleteEncodingRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcImage.DeleteEncodingReply> __Marshaller_DeleteEncodingReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcImage.DeleteEncodingReply.Parser));

    static readonly grpc::Method<global::GrpcImage.ProcessImageRequest, global::GrpcImage.ProcessImageReply> __Method_ProcessImage = new grpc::Method<global::GrpcImage.ProcessImageRequest, global::GrpcImage.ProcessImageReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ProcessImage",
        __Marshaller_ProcessImageRequest,
        __Marshaller_ProcessImageReply);

    static readonly grpc::Method<global::GrpcImage.CreateEncodingRequest, global::GrpcImage.CreateEncodingReply> __Method_CreateEncoding = new grpc::Method<global::GrpcImage.CreateEncodingRequest, global::GrpcImage.CreateEncodingReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateEncoding",
        __Marshaller_CreateEncodingRequest,
        __Marshaller_CreateEncodingReply);

    static readonly grpc::Method<global::GrpcImage.DeleteEncodingRequest, global::GrpcImage.DeleteEncodingReply> __Method_DeleteEncoding = new grpc::Method<global::GrpcImage.DeleteEncodingRequest, global::GrpcImage.DeleteEncodingReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteEncoding",
        __Marshaller_DeleteEncodingRequest,
        __Marshaller_DeleteEncodingReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcImage.ImageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ProcessImage</summary>
    public partial class ProcessImageClient : grpc::ClientBase<ProcessImageClient>
    {
      /// <summary>Creates a new client for ProcessImage</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProcessImageClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProcessImage that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProcessImageClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProcessImageClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProcessImageClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::GrpcImage.ProcessImageReply> ProcessImage(global::GrpcImage.ProcessImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ProcessImage(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GrpcImage.ProcessImageReply> ProcessImage(global::GrpcImage.ProcessImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ProcessImage, null, options, request);
      }
      public virtual global::GrpcImage.CreateEncodingReply CreateEncoding(global::GrpcImage.CreateEncodingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateEncoding(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcImage.CreateEncodingReply CreateEncoding(global::GrpcImage.CreateEncodingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateEncoding, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcImage.CreateEncodingReply> CreateEncodingAsync(global::GrpcImage.CreateEncodingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateEncodingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcImage.CreateEncodingReply> CreateEncodingAsync(global::GrpcImage.CreateEncodingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateEncoding, null, options, request);
      }
      public virtual global::GrpcImage.DeleteEncodingReply DeleteEncoding(global::GrpcImage.DeleteEncodingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteEncoding(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GrpcImage.DeleteEncodingReply DeleteEncoding(global::GrpcImage.DeleteEncodingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteEncoding, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcImage.DeleteEncodingReply> DeleteEncodingAsync(global::GrpcImage.DeleteEncodingRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteEncodingAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GrpcImage.DeleteEncodingReply> DeleteEncodingAsync(global::GrpcImage.DeleteEncodingRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteEncoding, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProcessImageClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProcessImageClient(configuration);
      }
    }

  }
}
#endregion
