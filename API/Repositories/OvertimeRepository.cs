﻿using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repositories;

public class OvertimeRepository : GeneralRepository<Overtime>, IOvertimeRepository
{
    public OvertimeRepository(OvertimeDbContext context) : base(context) { }
}
