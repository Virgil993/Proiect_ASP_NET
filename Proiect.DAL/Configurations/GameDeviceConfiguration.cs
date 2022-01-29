using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Configurations
{
    public class GameDeviceConfiguration : IEntityTypeConfiguration<GameDevice>
    {
        public void Configure(EntityTypeBuilder<GameDevice> builder)
        {
            builder.HasOne(p => p.Game)
                .WithMany(p => p.GameDevices)
                .HasForeignKey(p => p.GameId);

            builder.HasOne(p => p.Device)
                .WithMany(p => p.GameDevices)
                .HasForeignKey(p => p.DeviceId);
        }
    }
}
