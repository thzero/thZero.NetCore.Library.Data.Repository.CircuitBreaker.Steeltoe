/* ------------------------------------------------------------------------- *
thZero.NetCore.Library.Data.Repository.CircuitBreaker.Steeltoe
Copyright (C) 2016-2022 thZero.com

<development [at] thzero [dot] com>

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

	http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 * ------------------------------------------------------------------------- */

using System;

using Microsoft.Extensions.Logging;

namespace thZero.Data.Repository
{
    public abstract class RepositoryCircuitBreaker<TRepository, TCommand, TRequest, TResult> : RepositoryRequestCircuitBreaker<RepositoryHystrixCommand<TRepository, TRequest, TResult>, TRequest, TResult>
        where TRepository : IRepository
        where TCommand: RepositoryHystrixCommand<TRepository, TRequest, TResult>
    {
        public RepositoryCircuitBreaker(TRepository repository, ILogger<RepositoryCircuitBreaker<TRepository, TCommand, TRequest, TResult>> logger) : base(logger)
        {
        }
    }
}