function examples() {

    var products = [
        { Code: '001', Name: 'YAMATO CUTTING TORGUE' },
        { Code: '002', Name: 'YAMATO CUTTING TORGUE NOZZLE'},
        { Code: '003', Name: 'YAMATO CUTTING TORGUE' },
        { Code: '004', Name: 'PIPE 20"' },
        { Code: '005', Name: 'TRANSFORMER 2000KVA 20KV/414VOLT 50HZ' }
    ];

    var items = [
    ];

    var units = [
        { Code: '001', Name: 'PCS' }
    ];

    var requestors = [
        { text: "Abet", value: "1" },
        { text: "Bayu", value: "2" },
        { text: "Oscar", value: "3" },
        { text: "Bram", value: "4" }
    ];

    var projects = [
        { Code: 'P001', Name: 'PROJECT DHL M001' }
    ];

    var warehouses = [
        { Code: 'PST', Name: 'PUSAT' }
    ];

    var suppliers = [
        { Code: 'PS', Name: 'PT. PERMATA SOLUSINDO' },
        { Code: 'HUNDURE', Name: 'HUNDURE' }
    ];

    return {
        'products': products,
        'units': units,
        'requestors': requestors,
        'items': items,
        'projects': projects,
        'warehouses': warehouses,
        'suppliers': suppliers
    }
}