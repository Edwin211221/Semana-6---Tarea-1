using FarmaciaWinFormsEF.Data;
using FarmaciaWinFormsEF.Models;

namespace FarmaciaWinFormsEF.Controllers
{
    public class MedicamentoController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public List<Medicamento> ObtenerMedicamentos() => _context.Medicamentos.ToList();

        public void AgregarMedicamento(Medicamento medicamento)
        {
            _context.Medicamentos.Add(medicamento);
            _context.SaveChanges();
        }

        public void ActualizarMedicamento(Medicamento medicamento)
        {
            _context.Medicamentos.Update(medicamento);
            _context.SaveChanges();
        }

        public void EliminarMedicamento(int medicamentoId)
        {
            var medicamento = _context.Medicamentos.Find(medicamentoId);
            if (medicamento != null)
            {
                _context.Medicamentos.Remove(medicamento);
                _context.SaveChanges();
            }
        }
    }
}
