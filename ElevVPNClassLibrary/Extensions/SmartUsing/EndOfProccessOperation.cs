using ElevVPNClassLibrary.Core.Entities;
using System;

namespace ElevVPNClassLibrary.Extensions.SmartUsing
{
    internal class EndOfProcessOperation : IDisposable
    {
        private readonly BaseModel _model;

        public EndOfProcessOperation(BaseModel model)
        {
            _model = model;
        }

        public void Dispose()
        {
            _model.IsProcessing = !_model.IsProcessing;
        }
    }
}
