// -----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Sassy Solutions">
//     Copyright (c) 2026 Sassy Solutions. Licensed under the MIT License.
//     See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------------

// Stripe.net mutates process-wide static state (StripeConfiguration.ApiKey,
// StripeConfiguration.StripeClient) which multiple test fixtures need to set
// independently. Running collections in parallel makes those writes race —
// observed as a ~40% flake on Linux CI when one fixture's GET/POST request
// arrives while another fixture has just overwritten StripeClient.
// Serialising the whole assembly costs ~100ms and eliminates the flake.
[assembly: Xunit.CollectionBehavior(DisableTestParallelization = true)]
