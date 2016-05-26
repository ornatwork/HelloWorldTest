..\tools\Google.Protobuf.3.0.0-beta2\tools\protoc.exe -Iprotos --csharp_out .  --grpc_out .  protos/shared.proto --plugin=protoc-gen-grpc=..\tools\Grpc.Tools.0.13.0\tools\grpc_csharp_plugin.exe
