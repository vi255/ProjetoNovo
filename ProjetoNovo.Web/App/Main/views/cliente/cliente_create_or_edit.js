(function () {
    'use strict';

    angular
        .module('app')
        .controller('app.views.cliente.cliente_create_or_edit', ClienteModalController)

    ClienteModalController.$inject =
        [
            '$scope',
            '$uibModalInstance',
            'abp.services.app.cliente',
            'id',
            'isEditing'
        ];

    function ClienteModalController($scope, $uibModalInstance, clienteService, id, isEditing) {
        / jshint validthis:true /
        var vm = this;
        vm.save = save;
        vm.cancel = cancel;

        vm.isEditing = isEditing;
        vm.cliente = {
            telefones: [{ numeroTelefone: "", tipoTelefone: "Celular" }, { numeroTelefone: "", tipoTelefone: "Residencial" }, { numeroTelefone: "", tipoTelefone: "Opcional" }]
        };

        activate();

        function activate() {
            if (isEditing) {
                abp.ui.setBusy();
                getCliente();
            }
        }

        function getCliente() {
            clienteService.getById(id)
                .then(fillCliente, errorMessage)
                .catch(unblockByError);

            function fillCliente(result) {
                abp.ui.clearBusy();
                vm.cliente = result.data;
            }
        }

        function create() {
            abp.ui.setBusy();
            clienteService.createCliente(vm.cliente)
                .then(success)
                .catch(unblockByError);
        }

        function update() {
            abp.ui.setBusy();
            vm.cliente.telefones[0].tipoTelefone = "Celular";
            vm.cliente.telefones[1].tipoTelefone = "Residencial";
            vm.cliente.telefones[2].tipoTelefone = "Opcional";

            clienteService.updateCliente(vm.cliente)
                .then(success)
                .catch(unblockByError);
        }


        function success() {
            abp.ui.clearBusy();
            $uibModalInstance.close({});
        }

        function errorMessage(result) {
            abp.ui.clearBusy();
            abp.notify.error(result);
        }

        function unblockByError(error) {
            console.log(error);
            abp.ui.clearBusy();
        }

        function save() {
            if (isEditing) {
                update();
            } else {
                create();
            }
        };

        function cancel() {
            $uibModalInstance.dismiss({});
        };
    }

})();