using System;
using System.Collections.Generic;
using LlmTornado.Code;
using LlmTornado.Code.Models;

namespace LlmTornado.Chat.Models;

/// <summary>
/// GPT-5.3 class models from OpenAI.
/// </summary>
public class ChatModelOpenAiGpt53 : IVendorModelClassProvider
{
    /// <summary>
    /// GPT-5.3-Codex is the most capable agentic coding model, optimized for agentic coding tasks in Codex or similar environments.
    /// Supports low, medium, high, and xhigh reasoning effort settings.
    /// 400,000 context window, 128,000 max output tokens, Aug 31, 2025 knowledge cutoff.
    /// </summary>
    public static readonly ChatModel ModelV53Codex = new ChatModel("gpt-5.3-codex", LLmProviders.OpenAi, 400_000, [])
    {
        EndpointCapabilities = [ ChatModelEndpointCapabilities.Responses, ChatModelEndpointCapabilities.Batch ]
    };

    /// <summary>
    /// <inheritdoc cref="ModelV53Codex"/>
    /// </summary>
    public readonly ChatModel V53Codex = ModelV53Codex;

    /// <summary>
    /// All known GPT-5.3 models from OpenAI.
    /// </summary>
    public static List<IModel> ModelsAll => LazyModelsAll.Value;

    private static readonly Lazy<List<IModel>> LazyModelsAll = new Lazy<List<IModel>>(() => [
        ModelV53Codex
    ]);
    
    /// <summary>
    /// <inheritdoc cref="ModelsAll"/>
    /// </summary>
    public List<IModel> AllModels => ModelsAll;
    
    internal ChatModelOpenAiGpt53()
    {
        
    }
}
