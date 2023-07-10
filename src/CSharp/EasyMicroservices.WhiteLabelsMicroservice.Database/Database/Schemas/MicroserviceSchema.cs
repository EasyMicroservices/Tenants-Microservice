﻿namespace EasyMicroservices.WhiteLabelsMicroservice.Database.Schemas
{
    public class MicroserviceSchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int InstanceIndex { get; set; }
        public string ServerDestinationAddress { get; set; }
    }
}
