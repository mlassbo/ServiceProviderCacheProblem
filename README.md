# ServiceProviderCacheProblem
The purpose of this repo is to reproduce a suspicious behavior with the Entity Framework Core ServiceProviderCache. When running integration tests using WebApplicationFactory more and more ServiceProviders are added to the cache until a warning is logged or an error is thrown (depending on configuration).

## Steps to reproduce
Clone the repo and run dotnet test. The test that happen to run last will fail as by then the number of ServiceProviders in the cache have reached the limit of twenty.

Eleven tests are sufficient to trigger an error, so it seems there are two ServiceProviders added to the cache per test.
