﻿// <auto-generated/>
#nullable enable

namespace LudusBet.GraphQL
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddressResult : global::System.IEquatable<GetDesmosProfileByAddressResult>, IGetDesmosProfileByAddressResult
    {
        public GetDesmosProfileByAddressResult(global::LudusBet.GraphQL.IGetDesmosProfileByAddress_Profile_by_pk? profile_By_Pk)
        {
            Profile_by_pk = profile_By_Pk;
        }

        /// <summary>
        /// fetch data from the table: "profile" using primary key columns
        /// </summary>
        public global::LudusBet.GraphQL.IGetDesmosProfileByAddress_Profile_by_pk? Profile_by_pk { get; }

        public virtual global::System.Boolean Equals(GetDesmosProfileByAddressResult? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Profile_by_pk is null && other.Profile_by_pk is null) || Profile_by_pk != null && Profile_by_pk.Equals(other.Profile_by_pk)));
        }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetDesmosProfileByAddressResult)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                if (Profile_by_pk != null)
                {
                    hash ^= 397 * Profile_by_pk.GetHashCode();
                }

                return hash;
            }
        }
    }

    /// <summary>
    /// columns and relationships of "profile"
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddress_Profile_by_pk_profile : global::System.IEquatable<GetDesmosProfileByAddress_Profile_by_pk_profile>, IGetDesmosProfileByAddress_Profile_by_pk_profile
    {
        public GetDesmosProfileByAddress_Profile_by_pk_profile(global::System.String address)
        {
            Address = address;
        }

        public global::System.String Address { get; }

        public virtual global::System.Boolean Equals(GetDesmosProfileByAddress_Profile_by_pk_profile? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Address.Equals(other.Address));
        }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetDesmosProfileByAddress_Profile_by_pk_profile)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Address.GetHashCode();
                return hash;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial interface IGetDesmosProfileByAddressResult
    {
        /// <summary>
        /// fetch data from the table: "profile" using primary key columns
        /// </summary>
        public global::LudusBet.GraphQL.IGetDesmosProfileByAddress_Profile_by_pk? Profile_by_pk { get; }
    }

    /// <summary>
    /// columns and relationships of "profile"
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial interface IGetDesmosProfileByAddress_Profile_by_pk
    {
        public global::System.String Address { get; }
    }

    /// <summary>
    /// columns and relationships of "profile"
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial interface IGetDesmosProfileByAddress_Profile_by_pk_profile : IGetDesmosProfileByAddress_Profile_by_pk
    {
    }

    /// <summary>
    /// Represents the operation service of the GetDesmosProfileByAddress GraphQL operation
    /// <code>
    /// query GetDesmosProfileByAddress($address: String!) {
    ///   profile_by_pk(address: $address) {
    ///     __typename
    ///     address
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddressQueryDocument : global::StrawberryShake.IDocument
    {
        private GetDesmosProfileByAddressQueryDocument()
        {
        }

        public static GetDesmosProfileByAddressQueryDocument Instance { get; } = new GetDesmosProfileByAddressQueryDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x44, 0x65, 0x73, 0x6d, 0x6f, 0x73, 0x50, 0x72, 0x6f, 0x66, 0x69, 0x6c, 0x65, 0x42, 0x79, 0x41, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x28, 0x24, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x3a, 0x20, 0x53, 0x74, 0x72, 0x69, 0x6e, 0x67, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x70, 0x72, 0x6f, 0x66, 0x69, 0x6c, 0x65, 0x5f, 0x62, 0x79, 0x5f, 0x70, 0x6b, 0x28, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x3a, 0x20, 0x24, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x61, 0x64, 0x64, 0x72, 0x65, 0x73, 0x73, 0x20, 0x7d, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("md5Hash", "21934d1d4ce83f10739231e402963eab");
        public override global::System.String ToString()
        {
#if NETSTANDARD2_0
        return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#else
            return global::System.Text.Encoding.UTF8.GetString(Body);
#endif
        }
    }

    /// <summary>
    /// Represents the operation service of the GetDesmosProfileByAddress GraphQL operation
    /// <code>
    /// query GetDesmosProfileByAddress($address: String!) {
    ///   profile_by_pk(address: $address) {
    ///     __typename
    ///     address
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddressQuery : global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetDesmosProfileByAddressResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter;
        public GetDesmosProfileByAddressQuery(global::StrawberryShake.IOperationExecutor<IGetDesmosProfileByAddressResult> operationExecutor, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetDesmosProfileByAddressResult);
        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetDesmosProfileByAddressResult>> ExecuteAsync(global::System.String address, global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(address);
            return await _operationExecutor.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetDesmosProfileByAddressResult>> Watch(global::System.String address, global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(address);
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.String address)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();
            variables.Add("address", FormatAddress(address));
            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: GetDesmosProfileByAddressQueryDocument.Instance.Hash.Value, name: "GetDesmosProfileByAddress", document: GetDesmosProfileByAddressQueryDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default, variables: variables);
        }

        private global::System.Object? FormatAddress(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }

    /// <summary>
    /// Represents the operation service of the GetDesmosProfileByAddress GraphQL operation
    /// <code>
    /// query GetDesmosProfileByAddress($address: String!) {
    ///   profile_by_pk(address: $address) {
    ///     __typename
    ///     address
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial interface IGetDesmosProfileByAddressQuery : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetDesmosProfileByAddressResult>> ExecuteAsync(global::System.String address, global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetDesmosProfileByAddressResult>> Watch(global::System.String address, global::StrawberryShake.ExecutionStrategy? strategy = null);
    }

    /// <summary>
    /// Represents the DesmosClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class DesmosClient : global::LudusBet.GraphQL.IDesmosClient
    {
        private readonly global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery _getDesmosProfileByAddress;
        public DesmosClient(global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery getDesmosProfileByAddress)
        {
            _getDesmosProfileByAddress = getDesmosProfileByAddress ?? throw new global::System.ArgumentNullException(nameof(getDesmosProfileByAddress));
        }

        public static global::System.String ClientName => "DesmosClient";
        public global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery GetDesmosProfileByAddress => _getDesmosProfileByAddress;
    }

    /// <summary>
    /// Represents the DesmosClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial interface IDesmosClient
    {
        global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery GetDesmosProfileByAddress { get; }
    }
}

namespace LudusBet.GraphQL.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddressResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::LudusBet.GraphQL.GetDesmosProfileByAddressResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetDesmosProfileByAddressResultFactory(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult);
        public GetDesmosProfileByAddressResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetDesmosProfileByAddressResultInfo info)
            {
                return new GetDesmosProfileByAddressResult(MapIGetDesmosProfileByAddress_Profile_by_pk(info.Profile_by_pk, snapshot));
            }

            throw new global::System.ArgumentException("GetDesmosProfileByAddressResultInfo expected.");
        }

        private global::LudusBet.GraphQL.IGetDesmosProfileByAddress_Profile_by_pk? MapIGetDesmosProfileByAddress_Profile_by_pk(global::LudusBet.GraphQL.State.profileData? data, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetDesmosProfileByAddress_Profile_by_pk returnValue = default !;
            if (data?.__typename.Equals("profile", global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetDesmosProfileByAddress_Profile_by_pk_profile(data.Address ?? throw new global::System.ArgumentNullException());
            }
            else
            {
                throw new global::System.NotSupportedException();
            }

            return returnValue;
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddressResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public GetDesmosProfileByAddressResultInfo(global::LudusBet.GraphQL.State.profileData? profile_By_Pk, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            Profile_by_pk = profile_By_Pk;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        /// <summary>
        /// fetch data from the table: "profile" using primary key columns
        /// </summary>
        public global::LudusBet.GraphQL.State.profileData? Profile_by_pk { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetDesmosProfileByAddressResultInfo(Profile_by_pk, _entityIds, version);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class GetDesmosProfileByAddressBuilder : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        public GetDesmosProfileByAddressBuilder(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer idSerializer, global::StrawberryShake.IOperationResultDataFactory<global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String") ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetDesmosProfileByAddressResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetDesmosProfileByAddressResult Result, GetDesmosProfileByAddressResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;
            if (response.Exception is null)
            {
                try
                {
                    if (response.Body != null)
                    {
                        if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                        {
                            data = BuildData(dataElement);
                        }

                        if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                        {
                            errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                        }
                    }
                }
                catch (global::System.Exception ex)
                {
                    errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(ex.Message, exception: ex, extensions: new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>{{"body", response.Body?.RootElement.ToString()}})};
                }
            }
            else
            {
                if (response.Body != null && response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
                else
                {
                    errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(response.Exception.Message, exception: response.Exception, extensions: new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>{{"body", response.Body?.RootElement.ToString()}})};
                }
            }

            return new global::StrawberryShake.OperationResult<IGetDesmosProfileByAddressResult>(data?.Result, data?.Info, _resultDataFactory, errors);
        }

        private (IGetDesmosProfileByAddressResult, GetDesmosProfileByAddressResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default !;
            _entityStore.Update(session =>
            {
                snapshot = session.CurrentSnapshot;
            });
            var resultInfo = new GetDesmosProfileByAddressResultInfo(DeserializeIGetDesmosProfileByAddress_Profile_by_pk(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "profile_by_pk")), entityIds, snapshot.Version);
            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::LudusBet.GraphQL.State.profileData? DeserializeIGetDesmosProfileByAddress_Profile_by_pk(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value.GetProperty("__typename").GetString();
            if (typename?.Equals("profile", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::LudusBet.GraphQL.State.profileData(typename, address: DeserializeNonNullableString(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "address")));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }

    ///<summary>columns and relationships of "profile"</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class profileData
    {
        public profileData(global::System.String __typename, global::System.String? address = default !)
        {
            this.__typename = __typename ?? throw new global::System.ArgumentNullException(nameof(__typename));
            Address = address;
        }

        public global::System.String __typename { get; }

        public global::System.String? Address { get; }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class DesmosClientEntityIdFactory : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions()
        {Indented = false};
        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj.GetProperty("__typename").GetString()!;
            return __typename switch
            {
                _ => throw new global::System.NotSupportedException()};
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                _ => throw new global::System.NotSupportedException()};
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public partial class DesmosClientStoreAccessor : global::StrawberryShake.StoreAccessor
    {
        public DesmosClientStoreAccessor(global::StrawberryShake.IOperationStore operationStore, global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer entityIdSerializer, global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories, global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories) : base(operationStore, entityStore, entityIdSerializer, requestFactories, resultDataFactories)
        {
        }
    }
}

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.0.0")]
    public static partial class DesmosClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::LudusBet.GraphQL.State.DesmosClientStoreAccessor> AddDesmosClient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var serviceCollection = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp =>
            {
                ConfigureClientDefault(sp, serviceCollection, strategy);
                return new ClientServiceProvider(global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => new global::LudusBet.GraphQL.State.DesmosClientStoreAccessor(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::LudusBet.GraphQL.GetDesmosProfileByAddressQuery>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::LudusBet.GraphQL.DesmosClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::LudusBet.GraphQL.IDesmosClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            return new global::StrawberryShake.ClientBuilder<global::LudusBet.GraphQL.State.DesmosClientStoreAccessor>("DesmosClient", services, serviceCollection);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(global::System.IServiceProvider parentServices, global::Microsoft.Extensions.DependencyInjection.ServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(services, sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Transport.Http.IHttpConnection>(services, sp =>
            {
                var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("DesmosClient"));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UUIDSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.JsonSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(services, sp => new global::StrawberryShake.Serialization.SerializerResolver(global::System.Linq.Enumerable.Concat(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(parentServices), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>, global::LudusBet.GraphQL.State.GetDesmosProfileByAddressResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>, global::LudusBet.GraphQL.State.GetDesmosProfileByAddressBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>>(services, sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.IHttpConnection>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::LudusBet.GraphQL.IGetDesmosProfileByAddressResult>>(sp), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp), strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::LudusBet.GraphQL.GetDesmosProfileByAddressQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::LudusBet.GraphQL.IGetDesmosProfileByAddressQuery>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::LudusBet.GraphQL.GetDesmosProfileByAddressQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::LudusBet.GraphQL.State.DesmosClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::LudusBet.GraphQL.DesmosClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::LudusBet.GraphQL.IDesmosClient>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::LudusBet.GraphQL.DesmosClient>(sp));
            return services;
        }

        private class ClientServiceProvider : System.IServiceProvider, System.IDisposable
        {
            private readonly System.IServiceProvider _provider;
            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}
