# Cloud

## What is it?
- Servers and datacenters spread across the globe that offer their computing for rent
- Data management, storage, content delivery, email, social media

## Who?
- AWS (31%) Amazon Web Services
- Azure (25%) Microsoft Azure
- GCP (11%) Google Cloud Platform
- Others (~33%)
- https://www.statista.com/chart/18819/worldwide-market-share-of-leading-cloud-infrastructure-service-providers/

## Why rent? Cost to own?
- Own: Location, hardware, configurations, updates/maintenance, cyber security, physical security
- Rent: Pay as you go, only rent as much as you need

## Different Levels of Services / Shared Responsibility Models
- Infrastructure as a Service (IaaS) - Virtual Machine Azure, EC2 AWS
- Platform as a Service (PaaS) - Azure Web App, Azure SQL Server
- Software as a Service (SaaS) - Gmail, Google Drive
- https://learn.microsoft.com/en-us/azure/security/fundamentals/shared-responsibility

## SLA (service level agreement)
- Cloud Service Provider guarantees a certain amount of uptime
- 100% does not exist, things will go down, hardware will fail
- 99% (Dev) 3.6day/yr
- 99.9% (Prod) 9hr/yr
- 99.99% (Prod) 52min/yr
- 99.999% (mission critical) 5min/yr

## Region / Availability Zone
- Regions (Physical locations/ geographies): US East Coast, West Coast, Central, etc
- Availability Zone: physically separate (low latency) datacenters that are insulated (power, weather, network) from each other.
- https://gist.github.com/ausfestivus/04e55c7d80229069bf3bc75870630ec8
- https://learn.microsoft.com/en-us/azure/reliability/availability-zones-overview?tabs=azure-cli

## Scaling
- Vertical Scaling (Upgrade 1 thing) : quality
- Horizontal Scaling (Get more things) : quantity
- https://azure.microsoft.com/en-us/resources/cloud-computing-dictionary/scaling-out-vs-scaling-up

## Resources
- https://www.microsoft.com/en-us/trainingdays/azure
- https://learn.microsoft.com/en-us/training/paths/microsoft-azure-fundamentals-describe-cloud-concepts/
- https://learn.microsoft.com/en-us/certifications/exams/az-900/

## Setup for Azure Pipeline
- Request for increase parallelism
- https://forms.office.com/pages/responsepage.aspx?id=v4j5cvGGr0GRqy180BHbR5zsR558741CrNi6q8iTpANURUhKMVA3WE4wMFhHRExTVlpET1BEMlZSTCQlQCN0PWcu