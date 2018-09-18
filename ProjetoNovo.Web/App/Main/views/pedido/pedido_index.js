(function () {
    //use strict é um padrão de boa prática
    'use strict';

    //inicialização do angular
    angular
        .module('app')
        .controller('app.views.pedido.pedido_index', PedidoController)

    //injeção de componentes, como suporte para modal, serviço de tradução e a appservice de products
    PedidoController.$inject =
        [
            '$uibModal',
            'abp.services.app.pedido',
            '$location',
            '$state',
            '$timeout'
        ];

    function PedidoController($uibModal, pedidoService, $location, $state, $timeout) {
        /* jshint validthis:true */

        //nunca se esqueça de definir o vm como escopo
        var vm = this;

        //vm.createProduct, é uma variável que pode ser acessada no HTML
        //e que faz referencia a uma função chamada createProduct
        vm.createPedido = createPedido;
        vm.editPedido = editPedido;
        vm.delete = Delete;
        vm.refresh = refresh;

        vm.pedido = [];

        //chamada da função activate()
        activate();

        function activate() {
            abp.ui.setBusy();
            getPedido();
        }

        function refresh() {
            getPedido();
        }

        function getPedido() {
            pedidoService.getAllPedido({})
                .then(fillPedido, errorMessage)
                .catch(unblockByError);

            function fillPedido(result) {
                vm.pedido = result.data.pedido;
                app.ui.clearBusy();
            }

            function unblockByError() {
                abp.ui.clearBusy();
            }
        }

        function errorMessage(result) {
            abp.ui.clearBusy();
            abp.notify.error(result);
        }

        function createPedido() {
            var modalInstance = $uibModal.open({
                templateUrl: '/App/Main/views/pedido/pedido_create_or_edit.cshtml',
                controller: 'app.views.pedido.pedido_create_or_edit as vm',
                backdrop: 'static',
                resolve: {
                    id: function () {
                        return 0;
                    },
                    isEditing: function () {
                        return false;
                    }
                }
            });

            modalInstance.result.then(function () {
                getPedido();
            });
        }

        function editPedido(pedido) {
            var modalInstance = $uibModal.open({
                templateUrl: '/App/Main/views/pedido/pedido_create_or_edit.cshtml',
                controller: 'app.views.pedido.pedido_create_or_edit as vm',
                backdrop: 'static',
                resolve: {
                    id: function () {
                        return pedido.id;
                    },
                    isEditing: function () {
                        return true;
                    }
                }
            });

            modalInstance.result.then(function () {
                getPedido();
            });
        }

        function Delete(pedido) {
            swal({
                title: "Delete pedido",
                text: "Are you sure you want to delete '" + pedido.name + "'?",
                type: "warning",
                showCancelButton: true,
                confirmButtonCollor: "#DD6B55",
                confirmButtonText: "Yes, delete it!",
                closeOnConfirm: false,
                html: false
            }, function () {
                pedidoService.deletePedido(pedido.id)
                    .then(deletedMessage, errorMessage);
                function deletedMessage() {
                    swal("Deleted!",
                        "Your pedido has been deleted.",
                        "success");
                    getPedido();
                }
            });
        }
    }
})();