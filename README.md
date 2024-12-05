# EtheirysApiNetCore

A simple .NET wrapper to interact with [EtheirysApi](https://etheirysapi.com).

## Usage
### Retrieve an Entity by Id
```
EtheirysApiClient apiClient = new();
Item item = await apiClient.GetAsync<Item>(1);
```
### Retrieve an Entity paginated
EtheirysApiClient apiClient = new();
Paginated<ClassJob> classJobs = apiClient.GetPaginatedAsync(new ClassJobRequest()
            {
                Abbreviation = "WAR"
            });
```
